import heapq
from typing import List

from .problem import Problem

class Problem2163(Problem):
    def test(self) -> bool:
        nums = [7, 9, 5, 8, 1, 3]

        expected = 1
        result = self.minimumDifference(nums)

        print(result)

        return result == expected

    def minimumDifference(self, nums: List[int]) -> int:
        n = len(nums) // 3
        first = []
        second = []
        sumFirst = 0
        sumSecond = 0
        for i in range(n):
            heapq.heappush(first, -nums[i])
            heapq.heappush(second, nums[-(i + 1)])
            sumFirst += nums[i]
            sumSecond += nums[-(i + 1)]
        mins = [0] * (n + 1)
        mins[0] = sumFirst
        for i in range(n):
            heapq.heappush(first, -nums[n + i])
            removed = -heapq.heappop(first)
            mins[i + 1] = mins[i] - removed + nums[n + i]
        result = mins[n] - sumSecond
        for i in range(1, n + 1):
            heapq.heappush(second, nums[2 * n - i])
            removed = heapq.heappop(second)
            sumSecond = sumSecond - removed + nums[2 * n - i]
            diff = mins[n - i] - sumSecond
            if diff < result:
                result = diff

        return result
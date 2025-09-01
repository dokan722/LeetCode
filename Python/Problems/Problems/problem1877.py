import heapq
from typing import List

from .problem import Problem


class Problem1877(Problem):
    def test(self) -> bool:
        nums = [3, 5, 2, 3]

        expected = 7

        result = self.minPairSum(nums)

        print(result)

        return expected == result

    def minPairSum(self, nums: List[int]) -> int:
        nums.sort()
        half = len(nums) // 2
        n = len(nums)
        result = 0
        for i in range(half):
            result = max(result, nums[i] + nums[n - 1 - i])

        return result
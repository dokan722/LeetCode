from typing import List, Dict

from .problem import Problem


class Problem2270(Problem):
    def test(self) -> bool:
        nums = [10, 4, -8, 7]

        expected = 2

        result = self.waysToSplitArray(nums)

        print(result)

        return result == expected

    def waysToSplitArray(self, nums: List[int]) -> int:
        sumRight = 0
        for num in nums:
            sumRight += num

        sumLeft = 0
        result = 0
        for i in range(len(nums) - 1):
            sumRight -= nums[i]
            sumLeft += nums[i]
            if sumLeft >= sumRight:
                result += 1

        return result
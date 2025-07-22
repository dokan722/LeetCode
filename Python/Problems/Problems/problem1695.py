import sys
from typing import List

from .problem import Problem


class Problem1695(Problem):
    def test(self) -> bool:
        nums = [5, 2, 1, 2, 5, 2, 1, 2, 5]

        expected = 8

        result = self.maximumUniqueSubarray(nums)

        print(result)

        return expected == result

    def maximumUniqueSubarray(self, nums: List[int]) -> int:
        left = 0
        right = 0
        result = -sys.maxsize
        runningSum = 0
        indices = {}

        while right < len(nums):
            if nums[right] in indices:
                while left < indices[nums[right]] + 1:
                    runningSum -= nums[left]
                    left += 1
            indices[nums[right]] = right
            runningSum += nums[right]
            right += 1
            if runningSum > result:
                result = runningSum


        return result
import math
from typing import List, Dict

from .problem import Problem


class Problem2419(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 3, 2, 2]

        expected = 2

        result = self.longestSubarray(nums)

        print(result)

        return result == expected


    def longestSubarray(self, nums: List[int]) -> int:
        n = len(nums)
        maxLen = 1
        maxNum = nums[0]
        currLen = 1

        for i in range(1, n):
            if nums[i] == nums[i - 1]:
                currLen += 1
            else:
                if nums[i - 1] > maxNum or (nums[i - 1] == maxNum and currLen > maxLen):
                    maxNum = nums[i - 1]
                    maxLen = currLen
                currLen = 1
            if nums[n - 1] > maxNum or (nums[n - 1] == maxNum and currLen > maxLen):
                maxLen = currLen

        return maxLen
from typing import List

from .problem import Problem


class Problem1493(Problem):
    def test(self) -> bool:
        nums = [0, 1, 1, 1, 0, 1, 1, 0, 1]
        expected = 5

        result = self.longestSubarray(nums)

        print(result)

        return result == expected

    def longestSubarray(self, nums: List[int]) -> int:
        result = 0
        j = 0
        zeros = 0
        ones = 0
        for i in range(len(nums)):
            if nums[i] == 0:
                zeros += 1
            else:
                ones += 1
            while j < i and zeros > 1:
                if nums[j] == 0:
                    zeros -= 1
                else:
                    ones -= 1
                j += 1
            sub = 1 if zeros == 0 else 0
            if ones - sub > result:
                result = ones - sub

        return result
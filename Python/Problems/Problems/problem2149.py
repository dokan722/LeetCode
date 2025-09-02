import sys
from typing import List

from .problem import Problem


class Problem2149(Problem):
    def test(self) -> bool:
        nums = [3, 1, -2, -5, 2, -4]

        expected = [3, -2, 1, -5, 2, -4]

        result = self.rearrangeArray(nums)

        return result == expected

    def rearrangeArray(self, nums: List[int]) -> List[int]:
        n = len(nums)
        result = [0] * n
        neg = 1
        pos = 0
        for i in range(n):
            if nums[i] < 0:
                result[neg] = nums[i]
                neg += 2
            else:
                result[pos] = nums[i]
                pos += 2

        return result
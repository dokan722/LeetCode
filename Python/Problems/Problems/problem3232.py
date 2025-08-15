from typing import List, Dict

from .problem import Problem


class Problem3232(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4, 10]

        expected = False

        result = self.canAliceWin(nums)

        return result == expected

    def canAliceWin(self, nums: List[int]) -> bool:
        sumDigit = 0
        sumOther = 0
        for i in range(len(nums)):
            if nums[i] < 10:
                sumDigit += nums[i]
            else:
                sumOther += nums[i]


        return sumDigit != sumOther
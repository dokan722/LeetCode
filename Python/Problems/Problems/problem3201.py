from typing import List

from .problem import Problem

class Problem3201(Problem):
    def test(self) -> bool:
        nums = [1, 2, 1, 1, 2, 1, 2]

        expected = 6

        result = self.maximumLength(nums)

        print(result)

        return expected == result

    def maximumLength(self, nums: List[int]) -> int:
        odds = 0
        changes = 1
        odd = nums[0] % 2 == 1
        if odd:
            odds += 1
        for i in range(1, len(nums)):
            currOdd = nums[i] % 2 == 1
            if currOdd:
                odds += 1
            if currOdd != odd:
                changes += 1
                odd = currOdd

        return max(changes, odds, len(nums) - odds)
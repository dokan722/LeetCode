from typing import List

from .problem import Problem


class Problem3523(Problem):
    def test(self) -> bool:
        nums = [10,43,43,17,36,44,35,28]

        expected = 4

        result = self.maximumPossibleSize(nums)

        print(result)

        return result == expected

    def maximumPossibleSize(self, nums: List[int]) -> int:
        n = len(nums)
        reduced = 0
        i = 1
        while i < n:
            if nums[i] > nums[i - 1]:
                i += 1
                continue
            j = i
            while j < n and nums[j] < nums[i - 1]:
                j += 1
            reduced += j - i
            i = j
            i += 1

        return n - reduced
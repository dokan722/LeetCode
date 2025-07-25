from typing import List

from .problem import Problem


class Problem3487(Problem):
    def test(self) -> bool:
        nums = [1, 2, -1, -2, 1, 0, -1]

        expected = 3

        result = self.maxSum(nums)

        print(result)

        return result == expected

    def maxSum(self, nums: List[int]) -> int:
        valuesSet = set([x for x in nums if x > 0])
        m = max(nums)

        if m < 0:
            return m

        return sum(valuesSet)
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2221(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4, 5]

        expected = 8

        result = self.triangularSum(nums)

        print(result)

        return expected == result

    def triangularSum(self, nums: List[int]) -> int:
        n = len(nums)
        for i in range(1, n):
            for j in range(n - i):
                nums[j] = (nums[j] + nums[j + 1]) % 10

        return nums[0]
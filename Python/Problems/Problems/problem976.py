from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem976(Problem):
    def test(self) -> bool:
        nums = [2, 1, 2]

        expected = 5

        result = self.largestPerimeter(nums)

        print(result)

        return expected == result

    def largestPerimeter(self, nums: List[int]) -> int:
        n = len(nums)
        nums.sort()

        for i in range(n - 1, 1, -1):
            if nums[i] < nums[i - 1] + nums[i - 2]:
                return nums[i] + nums[i - 1] + nums[i - 2]

        return 0
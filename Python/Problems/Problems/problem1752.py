import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1752(Problem):
    def test(self) -> bool:
        nums = [3, 4, 5, 1, 2]

        expected = True

        result = self.check(nums)

        return result == expected

    def check(self, nums: List[int]) -> bool:
        n = len(nums)
        miss = 0
        for i in range(1, n):
            if nums[i - 1] > nums[i]:
                miss += 1
            if miss >= 2:
                return False

        return miss == 0 or nums[n - 1] <= nums[0]
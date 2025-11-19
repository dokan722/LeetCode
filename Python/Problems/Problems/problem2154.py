import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2154(Problem):
    def test(self) -> bool:
        nums = [5, 3, 6, 1, 12]
        original = 3

        expected = 24

        result = self.findFinalValue(nums, original)

        print(result)

        return result == expected

    def findFinalValue(self, nums: List[int], original: int) -> int:
        numsSet = set(nums)
        while original in numsSet:
            original <<= 1
        return original
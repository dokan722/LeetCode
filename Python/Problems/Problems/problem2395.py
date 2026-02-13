import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2395(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4, 5]

        expected = False

        result = self.findSubarrays(nums)

        return result == expected

    def findSubarrays(self, nums: List[int]) -> bool:
        n = len(nums)
        sums = set()
        for i in range(1, n):
            s = nums[i - 1] + nums[i]
            if s in sums:
                return True
            sums.add(s)

        return False
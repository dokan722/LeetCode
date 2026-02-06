import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3634(Problem):
    def test(self) -> bool:
        nums = [1, 6, 2, 9]
        k = 3

        expected = 2

        result = self.minRemoval(nums, k)

        print(result)

        return result == expected

    def minRemoval(self, nums: List[int], k: int) -> int:
        n = len(nums)
        result = 0
        nums.sort()
        r = 0
        for i in range(n):
            while r < n and nums[i] * k >= nums[r]:
                r += 1
            result = max(r - i, result)

        return n - result
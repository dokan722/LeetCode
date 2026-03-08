import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2587(Problem):
    def test(self) -> bool:
        nums = [2, -1, 0, 1, -3, 3, -3]

        expected = 6

        result = self.maxScore(nums)

        print(result)

        return result == expected

    def maxScore(self, nums: List[int]) -> int:
        n = len(nums)
        nums.sort()
        pre = 0
        for i in range(n - 1, -1, -1):
            pre += nums[i]
            if pre <= 0:
                return n - i - 1

        return n
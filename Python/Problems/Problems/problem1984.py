import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1984(Problem):
    def test(self) -> bool:
        nums = [9, 4, 1, 7]
        k = 2

        expected = 2

        result = self.minimumDifference(nums, k)

        print(result)

        return result == expected

    def minimumDifference(self, nums: List[int], k: int) -> int:
        nums.sort()
        minDiff = sys.maxsize
        for i in range(k - 1, len(nums)):
            minDiff = min(minDiff, nums[i] - nums[i - k + 1])

        return minDiff
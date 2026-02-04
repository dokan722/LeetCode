import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3818(Problem):
    def test(self) -> bool:
        nums = [1, -1, 2, 3, 3, 4, 5]

        expected = 4

        result = self.minimumPrefixLength(nums)

        print(result)

        return result == expected

    def minimumPrefixLength(self, nums: List[int]) -> int:
        n = len(nums)
        for i in range(n - 2, -1, -1):
            if nums[i] >= nums[i + 1]:
                return i + 1

        return 0
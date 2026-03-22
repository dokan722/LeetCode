import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem775(Problem):
    def test(self) -> bool:
        nums = [1, 0, 2]

        expected = True

        result = self.isIdealPermutation(nums)

        return expected == result

    def isIdealPermutation(self, nums: List[int]) -> bool:
        n = len(nums)
        for i in range(n):
            if abs(nums[i] - i) > 1:
                return False

        return True

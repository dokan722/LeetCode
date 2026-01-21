import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3315(Problem):
    def test(self) -> bool:
        nums = [2, 3, 5, 7]

        expected = [-1, 1, 4, 3]

        result = self.minBitwiseArray(nums)

        print1DArray(result)

        return expected == result

    def minBitwiseArray(self, nums: List[int]) -> List[int]:
        n = len(nums)
        result = []
        for i in range(n):
            if nums[i] == 2:
                result.append(-1)
            else:
                result.append(nums[i] - (((nums[i] + 1) & -(nums[i] + 1)) >> 1))

        return result
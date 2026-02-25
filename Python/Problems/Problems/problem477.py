import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem477(Problem):
    def test(self) -> bool:
        nums = [4, 14, 2]

        expected = 6

        result = self.totalHammingDistance(nums)

        print(result)

        return result == expected

    def totalHammingDistance(self, nums: List[int]) -> int:
        zeros = [0] * 32
        ones = [0] * 32
        result = 0
        for num in nums:
            tmp = num
            for i in range(32):
                rest = tmp % 2
                if rest == 0:
                    result += ones[i]
                    zeros[i] += 1
                else:
                    result += zeros[i]
                    ones[i] += 1
                tmp >>= 1

        return result
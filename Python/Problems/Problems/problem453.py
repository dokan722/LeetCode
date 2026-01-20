import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem453(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3]

        expected = 3

        result = self.minMoves(nums)

        print(result)

        return result == expected

    def minMoves(self, nums: List[int]) -> int:
        n = len(nums)
        m = sys.maxsize
        sum = 0
        for num in nums:
            sum += num
            m = min(m, num)
        return sum - n * m
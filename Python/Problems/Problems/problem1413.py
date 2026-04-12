import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1413(Problem):
    def test(self) -> bool:
        nums = [-3, 2, -3, 4, 2]

        expected = 5

        result = self.minStartValue(nums)

        print(result)

        return result == expected

    def minStartValue(self, nums: List[int]) -> int:
        minPoint = sys.maxsize
        s = 0
        for num in nums:
            s += num
            minPoint = min(s, minPoint)

        return 1 if minPoint > 0 else  abs(minPoint) + 1
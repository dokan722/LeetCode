import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3301(Problem):
    def test(self) -> bool:
        maximumHeight = [2, 3, 4, 3]

        expected = 10

        result = self.maximumTotalSum(maximumHeight)

        print(result)

        return result == expected

    def maximumTotalSum(self, maximumHeight: List[int]) -> int:
        n = len(maximumHeight)
        maximumHeight.sort()
        threshold = sys.maxsize
        result = 0
        for i in range(n - 1, -1, -1):
            if threshold < 1:
                return -1
            curr = min(maximumHeight[i], threshold)
            result += curr
            threshold = curr - 1

        return result
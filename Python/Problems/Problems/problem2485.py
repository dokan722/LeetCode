import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2485(Problem):
    def test(self) -> bool:
        n = 8

        expected = 6

        result = self.pivotInteger(n)

        print(result)

        return expected == result

    def pivotInteger(self, n: int) -> int:
        pivotValue = math.sqrt((n * n + n) / 2.0)
        return int(pivotValue) if pivotValue.is_integer() else -1
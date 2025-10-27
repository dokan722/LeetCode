import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1551(Problem):
    def test(self) -> bool:
        n = 3

        expected = 2

        result = self.minOperations(n)

        print(result)

        return expected == result

    def minOperations(self, n: int) -> int:
        half = n // 2
        if n % 2 == 1:
            return half * (half + 1)
        return n * (n - 1) // 2 - half * (half - 1)
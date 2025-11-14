import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2829(Problem):
    def test(self) -> bool:
        n = 5
        k = 4

        expected = 18

        result = self.minimumSum(n, k)

        print(result)

        return expected == result

    def minimumSum(self, n: int, k: int) -> int:
        half = k // 2
        if k < 3 or half > n:
            return n * (n + 1) // 2
        end = n + (k - half)
        return half * (half + 1) // 2 - k * (k - 1) // 2 + end * (end - 1) // 2
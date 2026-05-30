import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3091(Problem):
    def test(self) -> bool:
        k = 11

        expected = 5

        result = self.minOperations(k)

        print(result)

        return result == expected

    def minOperations(self, k: int) -> int:
        if k == 1:
            return 0
        x = int(math.sqrt(k - 1))
        return min(x - 1 + (k - 1) // x, x + (k - 1) // (x + 1))
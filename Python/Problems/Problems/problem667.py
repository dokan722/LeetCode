import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem667(Problem):
    def test(self) -> bool:
        n = 3
        k = 1

        expected = [1, 2, 3]

        result = self.constructArray(n, k)

        print1DArray(result)

        return expected == result

    def constructArray(self, n: int, k: int) -> List[int]:
        result = [0] * n
        diff = n - k
        result[0] = 1
        for i in range(1, diff):
            result[i] = result[i - 1] + 1
        for i in range(1, k + 1):
            result[diff + i - 1] = (n - k + i // 2) if (i % 2 == 0) else (n - i // 2)
        return result
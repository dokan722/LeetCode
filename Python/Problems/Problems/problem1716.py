import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1716(Problem):
    def test(self) -> bool:
        n = 20

        expected = 96

        result = self.totalMoney(n)

        print(result)

        return result == expected

    def totalMoney(self, n: int) -> int:
        full = n // 7
        rest = n % 7
        return 7 * full * (full - 1) // 2 + 28 * full + rest * full + rest * (rest + 1) // 2
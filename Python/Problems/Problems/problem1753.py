import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1753(Problem):
    def test(self) -> bool:
        a = 4
        b = 4
        c = 6

        expected = 7

        result = self.maximumScore(a, b, c)

        print(result)

        return result == expected

    def maximumScore(self, a: int, b: int, c: int) -> int:
        big = max(a, max(b, c))
        total = a + b + c
        rest = total - big
        return min(big, rest) + max(0, (rest - big) // 2)
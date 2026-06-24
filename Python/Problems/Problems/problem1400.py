import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1400(Problem):
    def test(self) -> bool:
        s = "annabelle"
        k = 2

        expected = True

        result = self.canConstruct(s, k)

        return result == expected

    def canConstruct(self, s: str, k: int) -> bool:
        if len(s) < k:
            return False
        counts = Counter(s)
        odd = 0
        for c in counts.values():
            if c % 2 == 1:
                odd += 1
        return odd <= k
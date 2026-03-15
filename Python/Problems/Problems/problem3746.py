import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3746(Problem):
    def test(self) -> bool:
        s = "aabbab"

        expected = 0

        result = self.minLengthAfterRemovals(s)

        print(result)

        return result == expected

    def minLengthAfterRemovals(self, s: str) -> int:
        na = 0
        for c in s:
            if c == 'a':
                na += 1

        return abs(len(s) - 2 * na)
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem190(Problem):
    def test(self) -> bool:
        n = 43261596

        expected = 964176192

        result = self.reverseBits(n)

        print(result)

        return expected == result

    def reverseBits(self, n: int) -> int:
        return self.reverseRec(n, 32)

    def reverseRec(self, n: int, l: int) -> int:
        if l == 1:
            return n & 1

        half = l >> 1
        mask = (1 << half) - 1
        lo = n & mask
        hi = n >> half

        return (self.reverseRec(lo, half) << half) | self.reverseRec(hi, half)

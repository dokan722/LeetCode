import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem693(Problem):
    def test(self) -> bool:
        n = 11

        expected = False

        result = self.hasAlternatingBits(n)

        return expected == result

    def hasAlternatingBits(self, n: int) -> bool:
        xor = n ^ (n >> 1)
        return (xor & (xor + 1)) == 0
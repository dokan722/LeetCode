import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2027(Problem):
    def test(self) -> bool:
        s = "XXOX"

        expected = 2

        result = self.minimumMoves(s)

        print(result)

        return expected == result

    def minimumMoves(self, s: str) -> int:
        n = len(s)
        result = 0
        i = 0
        while i < n:
            if s[i] == 'X':
                result += 1
                i += 2
            i += 1

        return result
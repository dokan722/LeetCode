import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3084(Problem):
    def test(self) -> bool:
        s = "abada"
        c = 'a'

        expected = 6

        result = self.countSubstrings(s, c)

        print(result)

        return result == expected

    def countSubstrings(self, s: str, c: str) -> int:
        k = s.count(c)
        return k * (k + 1) // 2
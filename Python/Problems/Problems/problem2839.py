import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2839(Problem):
    def test(self) -> bool:
        s1 = "abcd"
        s2 = "cdab"

        expected = True

        result = self.canBeEqual(s1, s2)

        return result == expected

    def canBeEqual(self, s1: str, s2: str) -> bool:
        n = len(s1)
        for i in range(n - 2):
            if (s1[i] != s2[i] or s1[i + 2] != s2[i + 2]) and (s1[i] != s2[i + 2] or s1[i + 2] != s2[i]):
                return False

        return True
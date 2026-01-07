import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2486(Problem):
    def test(self) -> bool:
        s = "coaching"
        t = "coding"

        expected = 4

        result = self.appendCharacters(s, t)

        print(result)

        return result == expected

    def appendCharacters(self, s: str, t: str) -> int:
        p = 0
        for c in s:
            if t[p] == c:
                p += 1
                if p == len(t):
                    return 0

        return len(t) - p
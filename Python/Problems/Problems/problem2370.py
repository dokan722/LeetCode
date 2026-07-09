import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2370(Problem):
    def test(self) -> bool:
        s = "acfgbd"
        k = 2

        expected = 4

        result = self.longestIdealString(s, k)

        print(result)

        return result == expected

    def longestIdealString(self, s: str, k: int) -> int:
        n = len(s)
        result = 1
        lens = [0] * 26
        for i in range(n):
            id = ord(s[i]) - ord('a')
            best = 0
            fr = max(0, id - k)
            to = min(25, id + k)
            for j in range(fr, to + 1):
                best = max(best, lens[j])
            lens[id] = best + 1
        for i in range(26):
            result = max(result, lens[i])
        return result
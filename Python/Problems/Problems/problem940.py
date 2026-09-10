import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem940(Problem):
    def test(self) -> bool:
        s = "abc"

        expected = 7

        result = self.distinctSubseqII(s)

        print(result)

        return result == expected

    def distinctSubseqII(self, s: str) -> int:
        result = 0
        prev = [0] * 26
        mod = 1000000007
        for c in s:
            id = ord(c) - ord('a')
            next = (result + 1 - prev[id] + mod) % mod
            result = (result + next) % mod
            prev[id] = (prev[id] + next) % mod

        return result
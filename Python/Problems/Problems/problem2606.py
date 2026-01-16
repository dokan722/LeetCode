import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2606(Problem):
    def test(self) -> bool:
        s = "adaa"
        chars = "d"
        vals = [-1000]

        expected = 2

        result = self.maximumCostSubstring(s, chars, vals)

        print(result)

        return result == expected

    def maximumCostSubstring(self, s: str, chars: str, vals: List[int]) -> int:
        n = len(s)
        m = len(chars)
        costs = [0] * 26
        for i in range(26):
            costs[i] = i + 1
        for i in range(m):
            costs[ord(chars[i]) - ord('a')] = vals[i]

        result = 0
        curr = 0
        for i in range(n):
            curr += costs[ord(s[i]) - ord('a')]
            result = max(curr, result)
            if curr < 0:
                curr = 0

        return result
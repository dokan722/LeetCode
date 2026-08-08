import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3983(Problem):
    def test(self) -> bool:
        s = "cat"
        t = "chat"

        expected = True

        result = self.canMakeSubsequence(s, t)

        return result == expected

    def canMakeSubsequence(self, s: str, t: str) -> bool:
        n = len(t)
        m = len(s)
        suf = [0] * n
        c = 0
        j = m - 1
        for i in range(n - 1, -1, -1):
            suf[i] = c
            if j > 0 and t[i] == s[j]:
                c += 1
                j -= 1
        j = 0
        i = 0
        changed = False
        while i < n and j < m:
            if s[j] == t[i]:
                j += 1
            elif not changed and suf[i] >= m - j - 1:
                j += 1
                changed = True
            i += 1

        return j == m
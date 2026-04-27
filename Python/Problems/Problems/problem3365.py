import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3365(Problem):
    def test(self) -> bool:
        s = "abcd"
        t = "cdab"
        k = 2

        expected = True

        result = self.isPossibleToRearrange(s, t, k)

        return result == expected

    def isPossibleToRearrange(self, s: str, t: str, k: int) -> bool:
        n = len(s)
        if n == k:
            return True
        fLen = n // k
        target = dict()
        for i in range(k):
            f = t[i * fLen:(i + 1) * fLen]
            if f in target:
                target[f] += 1
            else:
                target[f] = 1
        for i in range(k):
            f = s[i * fLen:(i + 1) * fLen]
            if f in target:
                target[f] -= 1
            else:
                target[f] = -1
            if target[f] < 0:
                return False
        for e in target.values():
            if e != 0:
                return False

        return True
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1208(Problem):
    def test(self) -> bool:
        s = "iktqzyazth"
        t = "havakbjzzc"
        maxCost = 78

        expected = 8

        result = self.equalSubstring(s, t, maxCost)

        print(result)

        return result == expected

    def equalSubstring(self, s: str, t: str, maxCost: int) -> int:
        n = len(s)
        currCost = 0
        r = 0
        result = 0
        for i in range(n):
            if i > 0:
                currCost -= abs(ord(s[i - 1]) - ord(t[i - 1]))
            while r < n and currCost <= maxCost:
                currCost += abs(ord(s[r]) - ord(t[r]))
                r += 1
            result = max(result, r - i - 1)
            if r == n:
                if currCost <= maxCost:
                    result = max(result, r - i)
                break

        return result
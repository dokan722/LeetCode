import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3713(Problem):
    def test(self) -> bool:
        s = "zzabccy"

        expected = 4

        result = self.longestBalanced(s)

        print(result)

        return result == expected

    def longestBalanced(self, s: str) -> int:
        n = len(s)
        result = 0
        for i in range(n):
            counts = [0] * 26
            for j in range(i, n):
                id = ord(s[j]) - ord('a')
                counts[id] += 1
                exp = counts[id]
                same = True
                for k in range(26):
                    if counts[k] != 0 and counts[k] != exp:
                        same = False
                        break
                if same:
                    result = max(j - i + 1, result)

        return result
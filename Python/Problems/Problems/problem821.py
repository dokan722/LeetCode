import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem821(Problem):
    def test(self) -> bool:
        s = "loveleetcode"
        c = 'e'

        expected = [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]

        result = self.shortestToChar(s, c)

        print1DArray(result)

        return expected == result

    def shortestToChar(self, s: str, c: str) -> List[int]:
        n = len(s)
        result = []
        dist = n + 1
        for i in range(n):
            if s[i] == c:
                dist = 0
            else:
                dist += 1
            result.append(dist)

        dist = n + 1
        for i in range(n - 1, -1, -1):
            if s[i] == c:
                dist = 0
            else:
                dist += 1
            result[i] = min(result[i], dist)

        return result
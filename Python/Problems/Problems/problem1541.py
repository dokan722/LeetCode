import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1541(Problem):
    def test(self) -> bool:
        s = "(()))"

        expected = 1

        result = self.minInsertions(s)

        print(result)

        return result == expected

    def minInsertions(self, s: str) -> int:
        n = len(s)
        d = 0
        result = 0
        i = 0
        while i < n:
            if s[i] == '(':
                d += 1
            if s[i] == ')':
                if i < n - 1 and s[i + 1] == ')':
                    i += 1
                else:
                    result += 1
                if d == 0:
                    result += 1
                else:
                    d -= 1
            i += 1
        return result + 2 * d
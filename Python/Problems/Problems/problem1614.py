import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1614(Problem):
    def test(self) -> bool:
        s = "(1+(2*3)+((8)/4))+1"

        expected = 3

        result = self.maxDepth(s)

        print(result)

        return result == expected

    def maxDepth(self, s: str) -> int:
        d = 0
        result = 0
        for c in s:
            if c == '(':
                d += 1
                result = max(result, d)
            elif c == ')':
                d -= 1

        return result
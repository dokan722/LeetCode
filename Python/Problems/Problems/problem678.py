import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem678(Problem):
    def test(self) -> bool:
        s = "(*))"

        expected = True

        result = self.checkValidString(s)

        return expected == result

    def checkValidString(self, s: str) -> bool:
        maxDepth = 0
        minDepth = 0
        for c in s:
            if c == '(':
                maxDepth += 1
                minDepth += 1
            elif c == ')':
                maxDepth -= 1
                minDepth -= 1
            else:
                maxDepth += 1
                minDepth -= 1
            if maxDepth < 0:
                return False
            minDepth = max(minDepth, 0)

        return minDepth == 0
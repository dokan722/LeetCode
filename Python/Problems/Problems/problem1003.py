import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1003(Problem):
    def test(self) -> bool:
        s = "aabcbc"

        expected = True

        result = self.isValid(s)

        return expected == result

    def isValid(self, s: str) -> bool:
        stack = []
        for c in s:
            if c == 'c':
                if not (len(stack) > 1 and stack.pop() == 'b' and stack.pop() == 'a'):
                    return False
            else:
                stack.append(c)

        return not stack
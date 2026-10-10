import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1021(Problem):
    def test(self) -> bool:
        s = "(()())(())"

        expected = "()()()"

        result = self.removeOuterParentheses(s)

        print(result)

        return result == expected

    def removeOuterParentheses(self, s: str) -> str:
        n = len(s)
        result = ''
        d = 0
        start = 0
        for i in range(n):
            if s[i] == '(':
                d += 1
            else:
                d -= 1
            if d == 0:
                result += s[(start + 1):i]
                start = i + 1

        return result
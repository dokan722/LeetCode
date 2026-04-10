import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem856(Problem):
    def test(self) -> bool:
        s = "()()"

        expected = 2

        result = self.scoreOfParentheses(s)

        print(result)

        return result == expected

    def scoreOfParentheses(self, s: str) -> int:
        n = len(s)
        depth = 0
        result = 0
        for i in range(n):
            if s[i] == '(':
                depth += 1
            else:
                depth -= 1
                if s[i - 1] == '(':
                    result += 1 << depth
        return result
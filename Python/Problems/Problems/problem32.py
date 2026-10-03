import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem32(Problem):
    def test(self) -> bool:
        s = "(()"

        expected = 2

        result = self.longestValidParentheses(s)

        print(result)

        return expected == result

    def longestValidParentheses(self, s: str) -> int:
        n = len(s)
        cur = 0
        start = 0
        result = 0
        for i in range(n):
            if s[i] == '(':
                cur += 1
            else:
                cur -= 1
            if cur < 0:
                start = i + 1
                cur = 0
            if cur == 0:
                result = max(result, i - start + 1)
        start = n - 1
        cur = 0
        for i in range(n - 1, -1, -1):
            if s[i] == ')':
                cur += 1
            else:
                cur -= 1
            if cur < 0:
                start = i - 1
                cur = 0
            if cur == 0:
                result = max(result, start - i + 1)

        return result
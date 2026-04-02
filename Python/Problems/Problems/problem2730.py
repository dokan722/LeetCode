import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2730(Problem):
    def test(self) -> bool:
        s = "52233"

        expected = 4

        result = self.longestSemiRepetitiveSubstring(s)

        print(result)

        return expected == result

    def longestSemiRepetitiveSubstring(self, s: str) -> int:
        n = len(s)
        bound = 0
        last = 0
        result = 0
        for i in range(1, n):
            if s[i] == s[i - 1]:
                result = max(result, i - bound);
                bound = last
                last = i
        result = max(result, n - bound)

        return result
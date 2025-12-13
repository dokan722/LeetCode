import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2414(Problem):
    def test(self) -> bool:
        s = "abacaba"

        expected = 2

        result = self.longestContinuousSubstring(s)

        print(result)

        return result == expected

    def longestContinuousSubstring(self, s: str) -> int:
        n = len(s)
        result = 0
        start = 0
        for i in range(1, n):
            if ord(s[i]) - ord(s[i - 1]) != 1:
                result = max(result, i - start)
                start = i

        result = max(result, n - start)

        return result
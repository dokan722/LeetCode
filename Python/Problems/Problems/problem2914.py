import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2914(Problem):
    def test(self) -> bool:
        s = "1001"

        expected = 2

        result = self.minChanges(s)

        print(result)

        return result == expected

    def minChanges(self, s: str) -> int:
        n = len(s)
        start = 0
        curr = s[0]
        result = 0
        for i in range(n):
            if s[i] != curr:
                l = i - start;
                if l % 2 != 0:
                    result += 1
                    i += 1
                start = i
                if i < n:
                    curr = s[i]

        return result
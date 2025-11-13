import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3228(Problem):
    def test(self) -> bool:
        s = "1001101"

        expected = 4

        result = self.maxOperations(s)

        print(result)

        return result == expected

    def maxOperations(self, s: str) -> int:
        n = len(s)
        result = 0
        ones = 0
        i = 0
        while i < n:
            if s[i] == '1':
                while i < n and s[i] == '1':
                    ones += 1
                    i += 1
                if i < n:
                    result += ones
            i += 1

        return result
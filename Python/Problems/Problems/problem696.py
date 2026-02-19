import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem696(Problem):
    def test(self) -> bool:
        s = "00110011"

        expected = 6

        result = self.countBinarySubstrings(s)

        print(result)

        return result == expected

    def countBinarySubstrings(self, s: str) -> int:
        n = len(s)
        last = 0
        while last < n - 1 and s[last] == s[last + 1]:
            last += 1
        result = 0
        prev = last + 1
        for i in range(last + 1, n - 1):
            if s[i] != s[i + 1]:
                curr = i - last
                result += min(curr, prev)
                last = i
                prev = curr
        result += min(prev, n - last - 1)

        return result
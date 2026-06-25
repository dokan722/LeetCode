import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1759(Problem):
    def test(self) -> bool:
        s = "abbcccaa"

        expected = 13

        result = self.countHomogenous(s)

        print(result)

        return result == expected

    def countHomogenous(self, s: str) -> int:
        n = len(s)
        first = 0
        result = 0
        mod = 1000000007
        for i in range(n):
            if s[i] != s[first]:
                l = i - first
                result = (result + l * (l + 1) // 2) % mod
                first = i
        ls = n - first
        result = (result + ls * (ls + 1) // 2) % mod
        return result
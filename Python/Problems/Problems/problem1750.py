import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1750(Problem):
    def test(self) -> bool:
        s = "ca"

        expected = 2

        result = self.minimumLength(s)

        print(result)

        return expected == result

    def minimumLength(self, s: str) -> int:
        n = len(s)
        l = 0
        r = n - 1
        while l < r and l < n and r >= 0 and s[l] == s[r]:
            c = s[l]
            while l < n and s[l] == c:
                l += 1
            while r >= 0 and s[r] == c:
                r -= 1

        if l < r:
            return r - l + 1
        return 1 if l == r else 0
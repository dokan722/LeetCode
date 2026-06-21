import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem172(Problem):
    def test(self) -> bool:
        n = 3

        expected = 0

        result = self.trailingZeroes(n)

        print(result)

        return result == expected

    def trailingZeroes(self, n: int) -> int:
        powers = []
        b = 5
        while b <= n:
            powers.append(b)
            b *= 5
        result = 0
        for f in powers:
            result += n // f
        return result
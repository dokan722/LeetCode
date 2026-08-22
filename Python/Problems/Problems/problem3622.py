import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3622(Problem):
    def test(self) -> bool:
        n = 99

        expected = True

        result = self.checkDivisibility(n)

        return result == expected

    def checkDivisibility(self, n: int) -> bool:
        prod = 1
        s = 0
        num = n
        while num > 0:
            d = num % 10
            prod *= d
            s += d
            num //= 10

        return n % (s + prod) == 0
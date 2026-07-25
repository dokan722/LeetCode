import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3536(Problem):
    def test(self) -> bool:
        n = 31

        expected = 3

        result = self.maxProduct(n)

        print(result)

        return result == expected

    def maxProduct(self, n: int) -> int:
        mx = 0
        mx2 = 0
        while n > 0:
            d = n % 10
            n //= 10
            if d >= mx:
                mx2 = mx
                mx = d
            elif d > mx2:
                mx2 = d
        return mx * mx2
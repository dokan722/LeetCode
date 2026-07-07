import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3754(Problem):
    def test(self) -> bool:
        n = 10203004

        expected = 12340

        result = self.sumAndMultiply(n)

        print(result)

        return result == expected

    def sumAndMultiply(self, n: int) -> int:
        x = 0
        s = 0
        cur = 1
        while n > 0:
            rem = n % 10
            if rem != 0:
                x += rem * cur
                s += rem
                cur *= 10
            n //= 10

        return x * s
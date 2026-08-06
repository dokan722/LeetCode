import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3345(Problem):
    def test(self) -> bool:
        n = 10
        t = 2

        expected = 10

        result = self.smallestNumber(n, t)

        print(result)

        return result == expected

    def smallestNumber(self, n: int, t: int) -> int:
        for i in range(n, n + 10 * t + 2):
            num = i
            prod = 1
            while num > 0:
                prod *= num % 10
                num //= 10
                if prod % t == 0:
                    return i

        return -1
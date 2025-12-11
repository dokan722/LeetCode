import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1925(Problem):
    def test(self) -> bool:
        n = 10

        expected = 4

        result = self.countTriples(n)

        print(result)

        return result == expected

    def countTriples(self, n: int) -> int:
        squares = set()
        for i in range(1, n + 1):
            squares.add(i * i)
        result = 0
        for i in range(1, n + 1):
            for j in range(1, n + 1):
                if (i * i + j * j) in squares:
                    result += 1

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1411(Problem):
    def test(self) -> bool:
        n = 5000

        expected = 30228214

        result = self.numOfWays(n)

        print(result)

        return result == expected

    def numOfWays(self, n: int) -> int:
        mod = 1000000007
        two = 6
        three = 6

        for i in range(1, n):
            nextTwo = (3 * two + 2 * three) % mod
            nextThree = (2 * two + 2 * three) % mod
            two = nextTwo
            three = nextThree

        return (two + three) % mod
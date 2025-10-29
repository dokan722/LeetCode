import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3370(Problem):
    def test(self) -> bool:
        n = 5

        expected = 7

        result = self.smallestNumber(n)

        print(result)

        return result == expected

    def smallestNumber(self, n: int) -> int:
        val = 2
        while val <= n:
            val <<= 1

        return val - 1
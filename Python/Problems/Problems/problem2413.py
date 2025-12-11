import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2413(Problem):
    def test(self) -> bool:
        n = 5

        expected = 10

        result = self.smallestEvenMultiple(n)

        print(result)

        return result == expected

    def smallestEvenMultiple(self, n: int) -> int:
        if n % 2 == 0:
            return n
        return 2 * n
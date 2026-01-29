import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3178(Problem):
    def test(self) -> bool:
        n = 3
        k = 5

        expected = 1

        result = self.numberOfChild(n, k)

        print(result)

        return result == expected

    def numberOfChild(self, n: int, k: int) -> int:
        even = (k // (n - 1)) % 2 == 0
        return (k % (n - 1)) if even else n - (k % (n - 1)) - 1
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2549(Problem):
    def test(self) -> bool:
        n = 5

        expected = 4

        result = self.distinctIntegers(n)

        print(result)

        return result == expected

    def distinctIntegers(self, n: int) -> int:
        return 1 if  n == 1 else n - 1
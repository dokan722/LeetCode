import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3226(Problem):
    def test(self) -> bool:
        n = 13
        k = 4

        expected = 2

        result = self.minChanges(n, k)

        print(result)

        return result == expected

    def minChanges(self, n: int, k: int) -> int:
        if ((n & k) != k):
            return -1
        return (n & ~k).bit_count()
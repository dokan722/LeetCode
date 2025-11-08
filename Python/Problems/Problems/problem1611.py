import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1611(Problem):
    def test(self) -> bool:
        n = 6

        expected = 4

        result = self.minimumOneBitOperations(n)

        print(result)

        return result == expected

    def minimumOneBitOperations(self, n: int) -> int:
        if n == 1:
            return 1

        k = 0
        curr = 1
        while curr * 2 <= n:
            curr *= 2
            k += 1

        return (1 << (k + 1)) - 1 - self.minimumOneBitOperations(n ^ curr)
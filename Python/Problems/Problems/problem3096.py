import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3096(Problem):
    def test(self) -> bool:
        possible = [1, 0, 1, 0]

        expected = 1

        result = self.minimumLevels(possible)

        print(result)

        return result == expected

    def minimumLevels(self, possible: List[int]) -> int:
        n = len(possible)
        total = 0
        for p in possible:
            total += -1 if p == 0 else 1

        alice = 0
        for i in range(n - 1):
            alice += -1 if possible[i] == 0 else 1
            bob = total - alice
            if bob < alice:
                return i + 1
        return -1
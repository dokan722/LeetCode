import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1052(Problem):
    def test(self) -> bool:
        customers = [1, 0, 1, 2, 1, 1, 7, 5]
        grumpy = [0, 1, 0, 1, 0, 1, 0, 1]
        minutes = 3

        expected = 16

        result = self.maxSatisfied(customers, grumpy, minutes)

        print(result)

        return result == expected

    def maxSatisfied(self, customers: List[int], grumpy: List[int], minutes: int) -> int:
        n = len(customers)
        satisfied = 0
        grumpies = 0
        best = 0
        for i in range(n):
            if (grumpy[i] == 0):
                satisfied += customers[i]
            else:
                grumpies += customers[i]
            if i >= minutes and grumpy[i - minutes] == 1:
                grumpies -= customers[i - minutes]
            best = max(best, grumpies)

        return satisfied + best
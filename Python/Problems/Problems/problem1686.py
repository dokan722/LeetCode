import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1686(Problem):
    def test(self) -> bool:
        aliceValues = [1, 3]
        bobValues = [2, 1]

        expected = 1

        result = self.stoneGameVI(aliceValues, bobValues)

        print(result)

        return result == expected

    def stoneGameVI(self, aliceValues: List[int], bobValues: List[int]) -> int:
        counts = Counter([a + b for a, b in zip(aliceValues, bobValues)])
        totalb = sum(bobValues)
        turn = 0
        a = 0
        for i in range(200, -1, -1):
            if i in counts:
                c = counts[i]
                a += i * ((c + (1 if turn % 2 == 0 else 0)) / 2)
                turn += c
        res = a - totalb
        if res > 0:
            return 1
        if res < 0:
            return -1
        return 0
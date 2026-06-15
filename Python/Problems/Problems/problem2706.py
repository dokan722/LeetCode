import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2706(Problem):
    def test(self) -> bool:
        prices = [1, 2, 2]
        money = 3

        expected = 0

        result = self.buyChoco(prices, money)

        print(result)

        return result == expected

    def buyChoco(self, prices: List[int], money: int) -> int:
        m = sys.maxsize
        mm = sys.maxsize
        for p in prices:
            if p <= m:
                mm = m
                m = p
            elif p < mm:
                mm = p

        rest = money - m - mm
        return rest if rest >= 0 else money
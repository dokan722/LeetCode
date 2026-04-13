import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1798(Problem):
    def test(self) -> bool:
        coins = [1, 3]

        expected = 2

        result = self.getMaximumConsecutive(coins)

        print(result)

        return result == expected

    def getMaximumConsecutive(self, coins: List[int]) -> int:
        coins.sort()
        result = 1
        for c in coins:
            if result < c:
                break
            result += c

        return result
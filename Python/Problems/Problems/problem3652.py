import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3652(Problem):
    def test(self) -> bool:
        prices = [4, 2, 8]
        strategy = [-1, 0, 1]
        k = 2

        expected = 10

        result = self.maxProfit(prices, strategy, k)

        print(result)

        return result == expected

    def maxProfit(self, prices: List[int], strategy: List[int], k: int) -> int:
        n = len(prices)
        half = k // 2
        total = 0
        currDiff = 0
        bestDiff = 0
        for i in range(n):
            curr = prices[i] * strategy[i]
            total += curr
            currDiff += prices[i] - curr
            if i >= half:
                currDiff -= prices[i - half]
            if i >= k - 1:
                if i >= k:
                    currDiff += prices[i - k] * strategy[i - k]
                bestDiff = max(bestDiff, currDiff)

        return total + bestDiff
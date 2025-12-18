import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem188(Problem):
    def test(self) -> bool:
        prices = [3, 2, 6, 5, 0, 3]
        k = 2

        expected = 7

        result = self.maxProfit(k, prices)

        print(result)

        return result == expected

    def maxProfit(self, k: int, prices: List[int]) -> int:
        n = len(prices)
        noneDp = [0] * (k + 1)
        buyingDp = [-prices[0]] * (k + 1)
        buyingDp[0] = 0

        for i in range(1, n):
            for j in range(k, 0, -1):
                noneDp[j] = max(noneDp[j], buyingDp[j] + prices[i])
                buyingDp[j] = max(buyingDp[j], noneDp[j - 1] - prices[i])

        return noneDp[k]
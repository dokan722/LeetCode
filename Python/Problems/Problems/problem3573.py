import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3573(Problem):
    def test(self) -> bool:
        prices = [12, 16, 19, 19, 8, 1, 19, 13, 9]
        k = 3

        expected = 36

        result = self.maximumProfit(prices, k)

        print(result)

        return result == expected

    def maximumProfit(self, prices: List[int], k: int) -> int:
        n = len(prices)
        noneDp = [0] * (k + 1)
        sellingDp = [prices[0]] * (k + 1)
        buyingDp = [-prices[0]] * (k + 1)
        sellingDp[0] = 0
        buyingDp[0] = 0

        for i in range(1, n):
            for j in range(k, 0, -1):
                noneDp[j] = max(noneDp[j], max(buyingDp[j] + prices[i], sellingDp[j] - prices[i]))
                sellingDp[j] = max(sellingDp[j], noneDp[j - 1] + prices[i])
                buyingDp[j] = max(buyingDp[j], noneDp[j - 1] - prices[i])

        return noneDp[k]
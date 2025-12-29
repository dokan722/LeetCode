import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem714(Problem):
    def test(self) -> bool:
        prices = [1, 3, 2, 8, 4, 9]
        fee = 2

        expected = 8

        result = self.maxProfit(prices, fee)

        print(result)

        return result == expected

    def maxProfit(self, prices: List[int], fee: int) -> int:
        n = len(prices)
        maxNone = 0
        maxBought = -prices[0] - fee
        for i in range(1, n):
            maxNone = max(maxNone, maxBought + prices[i])
            maxBought = max(maxBought, maxNone - prices[i] - fee)

        return maxNone
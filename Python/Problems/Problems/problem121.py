import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem121(Problem):
    def test(self) -> bool:
        prices = [7, 1, 5, 3, 6, 4]

        expected = 5

        result = self.maxProfit(prices)

        print(result)

        return expected == result

    def maxProfit(self, prices: List[int]) -> int:
        n = len(prices)
        currMin = prices[0]
        result = 0
        for i in range(1, n):
            currMin = min(currMin, prices[i])
            result = max(prices[i] - currMin, result)

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem122(Problem):
    def test(self) -> bool:
        prices = [7, 1, 5, 3, 6, 4]

        expected = 7

        result = self.maxProfit(prices)

        print(result)

        return expected == result

    def maxProfit(self, prices: List[int]) -> int:
        n = len(prices)
        currMin = prices[0]
        result = 0
        for i in range(1, n):
            if currMin < prices[i]:
                result += prices[i] - currMin
            currMin = prices[i]

        return result
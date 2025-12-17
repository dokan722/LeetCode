import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem123(Problem):
    def test(self) -> bool:
        prices = [3, 3, 5, 0, 0, 3, 1, 4]

        expected = 6

        result = self.maxProfit(prices)

        print(result)

        return result == expected

    def maxProfit(self, prices: List[int]) -> int:
        n = len(prices)
        empty = [0] * 3
        buying = [-prices[0]] * 3
        for i in range(1, n):
            empty[2] = max(empty[2], buying[2] + prices[i])
            buying[2] = max(buying[2], empty[1] - prices[i])
            empty[1] = max(empty[1], buying[1] + prices[i])
            buying[1] = max(buying[1], empty[0] - prices[i])

        return empty[2]
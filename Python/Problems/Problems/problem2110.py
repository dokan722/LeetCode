import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2110(Problem):
    def test(self) -> bool:
        prices = [3, 2, 1, 4]

        expected = 7

        result = self.getDescentPeriods(prices)

        print(result)

        return expected == result

    def getDescentPeriods(self, prices: List[int]) -> int:
        n = len(prices)
        result = 0
        start = 0
        i = 0
        while i < n:
            if prices[i - 1] - prices[i] != 1:
                l = i - start
                result += l * (l + 1) // 2
                start = i
            i += 1
        fl = n - start
        result += fl * (fl + 1) // 2

        return result
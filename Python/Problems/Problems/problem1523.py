import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1523(Problem):
    def test(self) -> bool:
        low = 3
        high = 7

        expected = 3

        result = self.countOdds(low, high)

        print(result)

        return expected == result

    def countOdds(self, low: int, high: int) -> int:
        l = high - low + 1
        if l % 2 == 0:
            return l // 2
        if low % 2 == 1:
            return (l + 1) // 2
        return (l - 1) // 2
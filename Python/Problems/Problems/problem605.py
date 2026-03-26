import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem605(Problem):
    def test(self) -> bool:
        flowerbed = [1, 0, 0, 0, 1]
        n = 1

        expected = True

        result = self.canPlaceFlowers(flowerbed, n)

        return result == expected

    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        m = len(flowerbed)
        last = -2
        for i in range(m):
            if flowerbed[i] == 1:
                l = i - last - 1
                last = i
                n -= (l - 1) // 2
        n -= (m - last - 1) // 2
        return n <= 0
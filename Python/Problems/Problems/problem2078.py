import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2078(Problem):
    def test(self) -> bool:
        colors = [1, 1, 1, 6, 1, 1, 1]

        expected = 3

        result = self.maxDistance(colors)

        print(result)

        return expected == result

    def maxDistance(self, colors: List[int]) -> int:
        n = len(colors)
        lastDif = n - 1
        while colors[lastDif] == colors[0]:
            lastDif -=1
        firstDif = 0
        while colors[firstDif] == colors[n - 1]:
            firstDif += 1

        return max(lastDif, n - firstDif - 1)
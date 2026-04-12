import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3492(Problem):
    def test(self) -> bool:
        n = 2
        w = 3
        maxWeight = 15

        expected = 4

        result = self.maxContainers(n, w, maxWeight)

        print(result)

        return expected == result

    def maxContainers(self, n: int, w: int, maxWeight: int) -> int:
        mc = maxWeight // w
        return min(n * n, mc)
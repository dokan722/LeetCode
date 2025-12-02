import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2141(Problem):
    def test(self) -> bool:
        n = 2
        batteries = [3, 3, 3]

        expected = 4

        result = self.maxRunTime(n, batteries)

        print(result)

        return expected == result

    def maxRunTime(self, n: int, batteries: List[int]) -> int:
        m = len(batteries)
        batteries.sort()
        start = m - n
        restSum = sum(batteries[:start])

        for i in range(start, m - 1):
            toFill = (batteries[i + 1] - batteries[i]) * (i - start + 1)
            if restSum > toFill:
                restSum -= toFill
            else:
                return batteries[i] + restSum // (i - start + 1)

        return batteries[m - 1] + restSum // n
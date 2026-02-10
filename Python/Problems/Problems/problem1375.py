import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1375(Problem):
    def test(self) -> bool:
        flips = [3, 2, 4, 1, 5]

        expected = 2

        result = self.numTimesAllBlue(flips)

        print(result)

        return result == expected

    def numTimesAllBlue(self, flips: List[int]) -> int:
        n = len(flips)
        result = 0
        last = -1
        for i in range(n):
            last = max(last, flips[i])
            if last == i + 1:
                result += 1

        return result
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3184(Problem):
    def test(self) -> bool:
        hours = [12, 12, 30, 24, 24]

        expected = 2

        result = self.countCompleteDayPairs(hours)

        print(result)

        return result == expected

    def countCompleteDayPairs(self, hours: List[int]) -> int:
        rests = [0] * 24
        result = 0
        for hour in hours:
            rem = hour % 24
            missing = (24 - rem) % 24
            result += rests[missing]
            rests[rem] += 1

        return result
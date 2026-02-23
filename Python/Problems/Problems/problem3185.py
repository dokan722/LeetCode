import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3185(Problem):
    def test(self) -> bool:
        hours = [12, 12, 30, 24, 24]

        expected = 2

        result = self.countCompleteDayPairs(hours)

        print(result)

        return result == expected

    def countCompleteDayPairs(self, hours: List[int]) -> int:
        result = 0
        counts = dict()
        for hour in hours:
            rem = hour % 24
            req = (24 - rem) % 24
            if req in counts:
                result += counts[req]
            if rem in counts:
                counts[rem] += 1
            else:
                counts[rem] = 1

        return result
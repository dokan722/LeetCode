import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem495(Problem):
    def test(self) -> bool:
        timeSeries = [1, 4]
        duration = 2

        expected = 4

        result = self.findPoisonedDuration(timeSeries, duration)

        print(result)

        return result == expected

    def findPoisonedDuration(self, timeSeries: List[int], duration: int) -> int:
        n = len(timeSeries)
        result = 0
        for i in range(n - 1):
            result += min(duration, timeSeries[i + 1] - timeSeries[i])

        return result + duration
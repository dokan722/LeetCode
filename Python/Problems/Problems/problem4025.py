import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem4025(Problem):
    def test(self) -> bool:
        period = 8
        lights = [2, 3]
        arrivalTime = [2, 5, 8, 11]

        expected = 5

        result = self.minPenalty(period, lights, arrivalTime)

        print(result)

        return result == expected

    def minPenalty(self, period: int, lights: list[int], arrivalTime: list[int]) -> int:
        mx = max(lights)

        result = 0
        for a in arrivalTime:
            r = a % period
            if r >= mx:
                result = max(result, period - r)

        return result
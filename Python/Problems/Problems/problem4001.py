import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem4001(Problem):
    def test(self) -> bool:
        series1 = [[1, 3], [4, 1]]
        series2 = [[2, 2], [5, 2]]

        expected = [[1, 5], [2, 3], [4, 3], [5, 2]]

        result = self.aggregateTimeSeries(series1, series2)

        print2DArray(result)

        return expected == result

    def aggregateTimeSeries(self, series1: list[list[int]], series2: list[list[int]]) -> list[list[int]]:
        n = len(series1)
        m = len(series2)
        i = 0
        j = 0
        result = []
        while i < n or j < m:
            c1 = series1[i] if  i < n else [sys.maxsize, 0]
            c2 = series2[j] if j < m else [sys.maxsize, 0]
            if c1[0] < c2[0]:
                result.append([c1[0], c1[1] + c2[1]])
                i += 1
            elif c1[0] > c2[0]:
                result.append([c2[0], c1[1] + c2[1]])
                j += 1
            else:
                result.append([c1[0], c1[1] + c2[1]])
                i += 1
                j += 1

        return result
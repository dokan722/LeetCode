import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1450(Problem):
    def test(self) -> bool:
        startTime = [1, 2, 3]
        endTime = [3, 2, 7]
        queryTime = 4

        expected = 1

        result = self.busyStudent(startTime, endTime, queryTime)

        print(result)

        return result == expected

    def busyStudent(self, startTime: List[int], endTime: List[int], queryTime: int) -> int:
        n = len(startTime)
        result = 0
        for i in range(n):
            if startTime[i] <= queryTime and endTime[i] >= queryTime:
                result += 1

        return result
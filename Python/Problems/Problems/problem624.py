import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem624(Problem):
    def test(self) -> bool:
        arrays = [[1, 2, 3], [4, 5], [1, 2, 3]]

        expected = 4

        result = self.maxDistance(arrays)

        print(result)

        return result == expected

    def maxDistance(self, arrays: List[List[int]]) -> int:
        n = len(arrays)
        smallest = arrays[0][0]
        biggest = arrays[0][-1]
        result = 0
        for i in range(1, n):
            curSmall = arrays[i][0]
            curBig = arrays[i][-1]
            result = max(result, abs(curBig - smallest))
            result = max(result, abs(biggest - curSmall))
            smallest = min(smallest, curSmall)
            biggest = max(biggest, curBig)

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3290(Problem):
    def test(self) -> bool:
        a = [-1, 4, 5, -2]
        b = [-5, -1, -3, -2, -4]

        expected = -1

        result = self.maxScore(a, b)

        print(result)

        return result == expected

    def maxScore(self, a: List[int], b: List[int]) -> int:
        n = len(b)
        result = [-sys.maxsize, -sys.maxsize, -sys.maxsize, -sys.maxsize]
        for i in range(n):
            next = []
            next.append(max(result[0], a[0] * b[i]))
            next.append(max(result[1], result[0] + a[1] * b[i]))
            next.append(max(result[2], result[1] + a[2] * b[i]))
            next.append(max(result[3], result[2] + a[3] * b[i]))
            result = next

        return result[3]
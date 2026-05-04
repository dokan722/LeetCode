import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1386(Problem):
    def test(self) -> bool:
        n = 3
        reservedSeats = [[1, 2], [1, 3], [1, 8], [2, 6], [3, 1], [3, 10]]

        expected = 4

        result = self.maxNumberOfFamilies(n, reservedSeats)

        print(result)

        return result == expected

    def maxNumberOfFamilies(self, n: int, reservedSeats: List[List[int]]) -> int:
        occupied = dict()
        for r in reservedSeats:
            if r[0] in occupied:
                cur = occupied[r[0]]
            else:
                cur = 7
            if r[1] > 1 and r[1] < 6:
                cur &= 6
            if r[1] > 3 and r[1] < 8:
                cur &= 5
            if r[1] > 5 and r[1] < 10:
                cur &= 3
            occupied[r[0]] = cur
        result = 2 * n
        for state in occupied.values():
            if state == 0:
                result -= 2
            elif state != 7 and state != 5:
                result -= 1

        return result
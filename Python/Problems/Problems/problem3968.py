import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3968(Problem):
    def test(self) -> bool:
        moves = "L_D_"

        expected = 4

        result = self.maxDistance(moves)

        print(result)

        return result == expected

    def maxDistance(self, moves: str) -> int:
        x = 0
        y = 0
        b = 0
        for m in moves:
            if m == 'U':
                x += 1
            elif m == 'D':
                x -= 1
            elif m == 'R':
                y += 1
            elif m == 'L':
                y -= 1
            else:
                b += 1

        return abs(x) + abs(y) + b
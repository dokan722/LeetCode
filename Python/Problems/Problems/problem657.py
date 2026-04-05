import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem657(Problem):
    def test(self) -> bool:
        moves = "UD"

        expected = True

        result = self.judgeCircle(moves)

        return expected == result

    def judgeCircle(self, moves: str) -> bool:
        x = 0
        y = 0
        for move in moves:
            if move == 'U':
                x += 1
            elif move == 'D':
                x -= 1
            elif move == 'L':
                y += 1
            elif move == 'R':
                y -= 1

        return x == 0 and y == 0
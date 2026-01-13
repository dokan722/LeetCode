import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3453(Problem):
    def test(self) -> bool:
        squares = [[0, 0, 2], [1, 1, 1]]

        expected = 1.16667

        result = self.separateSquares(squares)

        print(result)

        return abs(result - expected) < 1e-5

    def separateSquares(self, squares: List[List[int]]) -> float:
        bot = sys.maxsize
        top = -sys.maxsize

        for square in squares:
            bot = min(bot, square[1])
            top = max(top, square[1] + square[2])

        while abs(bot - top) > 1e-5:
            mid = (bot + top) / 2
            below = 0
            above = 0
            for square in squares:
                z = max(0, min(square[2], mid - square[1]))
                below += z * square[2]
                above += (square[2] - z) * square[2]
            if below >= above:
                top = mid
            else:
                bot = mid

        return bot
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1886(Problem):
    def test(self) -> bool:
        mat = [[0, 1], [1, 0]]
        target = [[1, 0], [0, 1]]

        expected = True

        result = self.findRotation(mat, target)

        return result == expected

    def findRotation(self, mat: List[List[int]], target: List[List[int]]) -> bool:
        n = len(mat)
        poss = 0b1111
        for i in range(n):
            for j in range(n):
                if mat[i][j] != target[i][j]:
                    poss &= 0b0111
                if mat[j][n - 1 - i] != target[i][j]:
                    poss &= 0b1011
                if mat[n - 1 - i][n - 1 - j] != target[i][j]:
                    poss &= 0b1101
                if mat[n - 1 - j][i] != target[i][j]:
                    poss &= 0b1110
                if poss == 0:
                    return False

        return True
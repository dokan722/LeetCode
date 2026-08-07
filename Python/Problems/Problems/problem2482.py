import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2482(Problem):
    def test(self) -> bool:
        grid = [[0, 1, 1], [1, 0, 1], [0, 0, 1]]

        expected = [[0, 0, 4], [0, 0, 4], [-2, -2, 2]]

        result = self.onesMinusZeros(grid)

        print2DArray(result)

        return expected == result

    def onesMinusZeros(self, grid: List[List[int]]) -> List[List[int]]:
        n = len(grid)
        m = len(grid[0])
        rowOnes = [0] * n
        rowZeros = [0] * n
        colOnes = [0] * m
        colZeros = [0] * m
        for i in range(n):
            for j in range(m):
                if grid[i][j] == 0:
                    rowZeros[i] += 1
                    colZeros[j] += 1
                elif grid[i][j] == 1:
                    rowOnes[i] += 1
                    colOnes[j] += 1
        result = []
        for i in range(n):
            row = []
            for j in range(m):
                row.append(rowOnes[i] + colOnes[j] - rowZeros[i] - colZeros[j])
            result.append(row)

        return result
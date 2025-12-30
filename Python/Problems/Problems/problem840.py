import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem840(Problem):
    def test(self) -> bool:
        grid = [[4, 3, 8, 4], [9, 5, 1, 9], [2, 7, 6, 2]]

        expected = 1

        result = self.numMagicSquaresInside(grid)

        print(result)

        return result == expected

    def numMagicSquaresInside(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        result = 0

        for i in range(n - 2):
            for j in range(m - 2):
                present = [False] * 9
                invalid = False
                for l in range(9):
                    val = grid[i + l // 3][j + l % 3]
                    if val < 1 or val > 9:
                        invalid = True
                        break
                    present[val - 1] = True
                for l in range(9):
                    if not present[l]:
                        invalid = True
                if (not invalid and grid[i][j] + grid[i][j + 1] + grid[i][j + 2] == 15 and
                    grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] == 15 and
                    grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] == 15 and
                    grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] == 15 and
                    grid[i][j] + grid[i + 1][j] + grid[i + 2][j] == 15 and
                    grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] == 15 and
                    grid[i][j + 2] + grid[i + 1][j + 2] + grid[i + 2][j + 2] == 15 and
                    grid[i][j + 2] + grid[i + 1][j + 1] + grid[i + 2][j] == 15):
                    result += 1

        return result
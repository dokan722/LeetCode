import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2658(Problem):
    def test(self) -> bool:
        grid = [[0, 2, 1, 0], [4, 0, 0, 3], [1, 0, 0, 4], [0, 3, 2, 0]]

        expected = 7

        result = self.findMaxFish(grid)

        print(result)

        return result == expected

    def findMaxFish(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        result = 0
        visited = [[False] * m for _ in range(n)]
        for i in range(n):
            for j in range(m):
                result = max(result, self.dfs(i, j, visited, grid))

        return result

    def dfs(self, x: int, y: int, visited: List[List[bool]], grid: List[List[int]]) -> int:
        if x < 0 or x >= len(visited) or y < 0 or y >= len(visited[0]) or visited[x][y] or grid[x][y] == 0:
            return 0
        visited[x][y] = True
        return grid[x][y] + self.dfs(x - 1, y, visited, grid) + self.dfs(x, y - 1, visited, grid) + self.dfs(x + 1, y, visited, grid) + self.dfs(x, y + 1, visited, grid)
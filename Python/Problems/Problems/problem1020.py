import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1020(Problem):
    def test(self) -> bool:
        grid = [[0, 0, 0, 0], [1, 0, 1, 0], [0, 1, 1, 0], [0, 0, 0, 0]]

        expected = 3

        result = self.numEnclaves(grid)

        print(result)

        return result == expected

    def numEnclaves(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        que = deque()
        dirs = [[-1, 0], [0, -1], [1, 0], [0, 1]]
        result = 0
        for i in range(n):
            for j in range(m):
                if grid[i][j] == 0:
                    continue
                grid[i][j] = 0
                que.append((i, j))
                enc = 1
                exit = False
                while que:
                    p = que.popleft()
                    for d in dirs:
                        x = p[0] + d[0]
                        y = p[1] + d[1]
                        if x >= 0 and x < n and y >= 0 and y < m:
                            if grid[x][y] == 1:
                                grid[x][y] = 0
                                enc += 1
                                que.append((x, y))
                        else:
                            exit = True
                if not exit:
                    result += enc

        return result
import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3286(Problem):
    def test(self) -> bool:
        grid = [[0, 1, 0, 0, 0], [0, 1, 0, 1, 0], [0, 0, 0, 1, 0]]
        health = 1

        expected = True

        result = self.findSafeWalk(grid, health)

        return result == expected

    def findSafeWalk(self, grid: List[List[int]], health: int) -> bool:
        if grid[0][0] == 1:
            health -= 1
        dirs = [[1, 0], [0, 1], [-1, 0], [0, -1]]
        n = len(grid)
        m = len(grid[0])
        visited = [[False for _ in range(m)] for _ in range(n)]
        curq = deque()
        nextq = deque()
        curq.append((0, 0))
        visited[0][0] = True
        while health > 0 and (len(curq) > 0 or len(nextq) > 0):
            if len(curq) == 0:
                health -= 1
                curq = nextq
                nextq = deque()
            else:
                next = curq.popleft()
                if next[0] == n - 1 and next[1] == m - 1:
                    return True
                for dir in dirs:
                    x = next[0] + dir[0]
                    y = next[1] + dir[1]
                    if x >= 0 and x < n and y >= 0 and y < m and not visited[x][y]:
                        visited[x][y] = True
                        if grid[x][y] == 0:
                            curq.append((x, y))
                        else:
                            nextq.append((x, y))

        return False
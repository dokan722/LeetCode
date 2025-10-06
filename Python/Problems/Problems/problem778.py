import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem778(Problem):
    def test(self) -> bool:
        grid = [[0, 1, 2, 3, 4], [24, 23, 22, 21, 5], [12, 13, 14, 15, 16], [11, 17, 18, 19, 20], [10, 9, 8, 7, 6]]

        expected = 16

        result = self.swimInWater(grid)

        print(result)

        return expected == result

    def swimInWater(self, grid: List[List[int]]) -> int:
        n = len(grid)
        visited = []
        for i in range(n):
            visited.append([False] * n)
        queue = []
        heapq.heappush(queue, (grid[0][0], 0, 0))

        while queue:
            (lvl, x, y) = heapq.heappop(queue)
            if visited[x][y]:
                continue
            visited[x][y] = True
            if x == n - 1 and x == y:
                return lvl
            if x > 0 and not visited[x - 1][y]:
                 heapq.heappush(queue, (max(grid[x - 1][y], lvl), x - 1, y))
            if x < n - 1 and not visited[x + 1][y]:
                heapq.heappush(queue, (max(grid[x + 1][y], lvl), x + 1, y))
            if y > 0 and not visited[x][y - 1]:
                heapq.heappush(queue, (max(grid[x][y - 1], lvl), x, y - 1))
            if y < n - 1 and not visited[x][y + 1]:
                heapq.heappush(queue, (max(grid[x][y + 1], lvl), x, y + 1))

        return 0
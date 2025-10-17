import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3462(Problem):
    def test(self) -> bool:
        grid = [[5, 3, 7], [8, 2, 6]]
        limits = [2, 2]
        k = 3

        expected = 21

        result = self.maxSum(grid, limits, k)

        print(result)

        return result == expected

    def maxSum(self, grid: List[List[int]], limits: List[int], k: int) -> int:
        n = len(grid)
        m = len(grid[0])
        que = []
        for i in range(n):
            for j in range(m):
                heapq.heappush(que, (-grid[i][j], i))
        filled = [0] * n
        taken = 0
        result = 0
        while que and taken < k:
            item = heapq.heappop(que)
            if filled[item[1]] < limits[item[1]]:
                result += -item[0]
                filled[item[1]] += 1
                taken += 1

        return result
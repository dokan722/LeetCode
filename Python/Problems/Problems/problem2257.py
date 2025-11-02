import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2257(Problem):
    def test(self) -> bool:
        m = 4
        n = 6
        guards = [[0, 0], [1, 1], [2, 3]]
        walls = [[0, 1], [2, 2], [1, 4]]

        expected = 7

        result = self.countUnguarded(m, n, guards, walls)

        print(result)

        return result == expected

    def countUnguarded(self, m: int, n: int, guards: List[List[int]], walls: List[List[int]]) -> int:
        prison = []
        for i in range(m):
            prison.append([0] * n)
        for guard in guards:
            prison[guard[0]][guard[1]] = 2

        for wall in walls:
            prison[wall[0]][wall[1]] = 3


        for i in range(m):
            state = False
            for j in range(n):
                state = self.checkCell(i, j, state, prison)
            state = False
            for j in range(n - 1, -1, -1):
                state = self.checkCell(i, j, state, prison)

        for i in range(n):
            state = False
            for j in range(m):
                state = self.checkCell(j, i, state, prison)
            state = False
            for j in range(m - 1, -1, -1):
                state = self.checkCell(j, i, state, prison)

        result = 0
        for i in range(m):
            for j in range(n):
                if prison[i][j] == 0:
                    result += 1

        return result

    def checkCell(self, i: int, j: int, state: bool, prison: List[List[int]]) -> bool:
        val = prison[i][j]
        if val == 2:
            state = True
        elif val == 3:
            state = False
        elif state:
            prison[i][j] = 1
        return state

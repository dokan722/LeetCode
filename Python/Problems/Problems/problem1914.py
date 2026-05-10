import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1914(Problem):
    def test(self) -> bool:
        grid = [[40, 10], [30, 20]]
        k = 1

        expected = [[10, 20], [40, 30]]

        result = self.rotateGrid(grid, k)

        print2DArray(result)

        return expected == result

    def rotateGrid(self, grid: List[List[int]], k: int) -> List[List[int]]:
        n = len(grid)
        m = len(grid[0])
        result = [[0 for _ in range(m)] for _ in range(n)]
        for i in range(min(n, m) // 2):
            layerH = n - 2 * i
            layerW = m - 2 * i
            layerLen = 2 * layerH + 2 * layerW - 4
            d = k % layerLen
            for j in range(layerLen):
                resCord = self.getCoords(i, j, layerW, layerH, n, m)
                orgCord = self.getCoords(i, (j + d) % layerLen, layerW, layerH, n, m)
                result[resCord[0]][resCord[1]] = grid[orgCord[0]][orgCord[1]]


        return result

    def getCoords(self, layerNum: int, pos: int, layerW: int, layerH: int, h: int, w: int) -> (int, int):
        x = 0
        y = 0
        if pos < layerW:
            x = layerNum
            y = layerNum + pos
        elif pos < layerW + layerH - 1:
            x = layerNum + (pos - layerW + 1)
            y = w - 1 - layerNum
        elif pos < 2 * layerW + layerH - 2:
            x = h - layerNum - 1
            y = w - 1 - layerNum - (pos - layerW - layerH + 2)
        else:
            x = h - 1 - layerNum - (pos - 2 * layerW - layerH + 3)
            y = layerNum

        return (x, y)
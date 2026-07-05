import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1301(Problem):
    def test(self) -> bool:
        board = ["E23", "2X2", "12S"]

        expected = [7, 1]

        result = self.pathsWithMaxScore(board)

        print1DArray(result)

        return expected == result

    def pathsWithMaxScore(self, board: List[str]) -> List[int]:
        n = len(board)
        mxs = [[0 for _ in range(n)] for _ in range(n)]
        cnts = [[0 for _ in range(n)] for _ in range(n)]
        mod = 1000000007
        mxs[n - 1][n - 1] = 0
        cnts[n - 1][n - 1] = 1
        for i in range(n - 1, -1, -1):
            for j in range(n - 1, -1, -1):
                canDown = i != n - 1
                canRight = j != n - 1
                if board[i][j] != 'X' and (canDown or canRight):
                    downMx = mxs[i + 1][j] if canDown else 0
                    rightMx = mxs[i][j + 1] if canRight else 0
                    crossMx = mxs[i + 1][j + 1] if canDown and canRight else 0
                    best = max(max(downMx, rightMx), crossMx)
                    downCnt = cnts[i + 1][j] if canDown and (downMx == best) else 0
                    rightCnt = cnts[i][j + 1] if canRight and (rightMx == best) else 0
                    crossCnt = cnts[i + 1][j + 1] if canRight and canDown and (crossMx == best) else 0
                    curCnt = (downCnt + rightCnt + crossCnt) % mod
                    curVal = ord(board[i][j]) - ord('0') if  board[i][j] != 'E' else 0
                    mxs[i][j] = best + curVal if curCnt != 0 else 0
                    cnts[i][j] = curCnt

        return [mxs[0][0], cnts[0][0]]
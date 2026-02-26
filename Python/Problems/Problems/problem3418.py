import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3418(Problem):
    def test(self) -> bool:
        coins = [[-7, 12, 12, 13], [-6, 19, 19, -6], [9, -2, -10, 16], [-4, 14, -10, -9]]

        expected = 60

        result = self.maximumAmount(coins)

        print(result)

        return result == expected

    def maximumAmount(self, coins: List[List[int]]) -> int:
        n = len(coins)
        m = len(coins[0])
        l = 3
        paths = [[[0] * l for _ in range(m)] for _ in range(n)]

        for i in range(n):
            for j in range(m):
                if i == 0 and j == 0:
                    paths[i][j][0] = coins[0][0]
                    for k in range(1, l):
                        paths[i][j][k] = max(0, coins[0][0])
                else:
                    up = paths[i - 1][j][0] if  i > 0 else -sys.maxsize
                    left = paths[i][j - 1][0] if j > 0 else -sys.maxsize
                    paths[i][j][0] = max(up, left) + coins[i][j]
                    for k in range(1, l):
                        up = paths[i - 1][j][k - 1] if i > 0 else -sys.maxsize
                        left = paths[i][j - 1][k - 1] if j > 0 else -sys.maxsize
                        upStay = paths[i - 1][j][k] if i > 0 else -sys.maxsize
                        leftStay = paths[i][j - 1][k] if j > 0 else -sys.maxsize
                        paths[i][j][k] = max(max(upStay, leftStay) + coins[i][j], max(up, left) + max(0, coins[i][j]))

        return paths[n - 1][m - 1][l - 1]
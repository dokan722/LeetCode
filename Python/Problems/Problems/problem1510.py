import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1510(Problem):
    def test(self) -> bool:
        n = 4

        expected = True

        result = self.winnerSquareGame(n)

        return expected == result

    def winnerSquareGame(self, n: int) -> bool:
        dp = [-1] * (n + 1)
        return self.canWin(dp, n)

    def canWin(self, dp: List[int], n: int) -> bool:
        if n <= 0:
            return False
        if dp[n] != -1:
            return dp[n] == 1
        limit = int(math.sqrt(n) + 1)
        res = 0
        for i in range(1, limit):
            if not self.canWin(dp, n - i * i):
                res = 1
                break
        dp[n] = res

        return res == 1
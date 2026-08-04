import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1406(Problem):
    def test(self) -> bool:
        stoneValue = [1, 2, 3, 7]

        expected = "Bob"

        result = self.stoneGameIII(stoneValue)

        print(result)

        return result == expected

    def stoneGameIII(self, stoneValue: List[int]) -> str:
        n = len(stoneValue)
        a = "Alice"
        b = "Bob"
        t = "Tie"
        dp = [0] * (n + 1)
        for i in range(n - 1, -1, -1):
            best = -sys.maxsize
            s = 0
            for k in range(1, 4):
                if i + k > n:
                    break
                s += stoneValue[i + k - 1]
                best = max(best, s - dp[i + k])
            dp[i] = best
        if dp[0] > 0:
            return a
        if dp[0] < 0:
            return b
        return t
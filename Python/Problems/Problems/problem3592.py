import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3592(Problem):
    def test(self) -> bool:
        numWays = [0, 1, 0, 2, 0, 3, 0, 4, 0, 5]

        expected = [2, 4, 6]

        result = self.findCoins(numWays)

        print1DArray(result)

        return expected == result

    def findCoins(self, numWays: List[int]) -> List[int]:
        n = len(numWays)
        dp = [0] * (n + 1)
        dp[0] = 1
        result = []
        for i in range(1, n + 1):
            if dp[i] != numWays[i - 1]:
                if numWays[i - 1] - dp[i] != 1:
                    return []
                dp[i] += 1
                for j in range(i + 1, n + 1):
                    dp[j] += dp[j - i]
                result.append(i)

        return result
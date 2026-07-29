import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem322(Problem):
    def test(self) -> bool:
        coins = [1, 2, 5]
        amount = 11

        expected = 3

        result = self.coinChange(coins, amount)

        print(expected)

        return result == expected

    def coinChange(self, coins: List[int], amount: int) -> int:
        dp = [0]
        for i in range(1, amount + 1):
            dp.append(sys.maxsize)
            for c in coins:
                req = i - c
                if req >= 0 and dp[req] != sys.maxsize:
                    dp[i] = min(dp[i], dp[req] + 1)

        return -1 if dp[amount] == sys.maxsize else dp[amount]
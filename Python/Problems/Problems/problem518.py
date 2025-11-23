import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem518(Problem):
    def test(self) -> bool:
        amount = 5
        coins = [1, 2, 5]

        expected = 4

        result = self.change(amount, coins)

        print(result)

        return result == expected

    def change(self, amount: int, coins: List[int]) -> int:
        dp = [0] * (amount + 1)
        dp[0] = 1
        n = len(coins)
        for i in range(n):
            for j in range(coins[i], amount + 1):
                dp[j] += dp[j - coins[i]]

        return dp[amount]
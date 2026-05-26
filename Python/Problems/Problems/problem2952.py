import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2952(Problem):
    def test(self) -> bool:
        coins = [1, 4, 10]
        target = 19

        expected = 2

        result = self.minimumAddedCoins(coins, target)

        print(result)

        return result == expected

    def minimumAddedCoins(self, coins: List[int], target: int) -> int:
        n = len(coins)
        result = 0
        mx = 0
        coins.sort()
        i = 0
        while (mx < target):
            if i < n and coins[i] <= mx + 1:
                mx += coins[i]
                i += 1
            else:
                result += 1
                mx += mx + 1

        return result
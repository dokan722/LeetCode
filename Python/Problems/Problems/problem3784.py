import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3784(Problem):
    def test(self) -> bool:
        s = "aabaac"
        cost = [1, 2, 3, 4, 1, 10]

        expected = 11

        result = self.minCost(s, cost)

        print(result)

        return result == expected

    def minCost(self, s: str, cost: List[int]) -> int:
        n = len(s)
        total = 0
        mx = 0
        costs = [0] * 26
        for i in range(n):
            costs[ord(s[i]) - ord('a')] += cost[i]
            total += cost[i]
        for i in range(26):
            mx = max(mx, costs[i])
        return total - mx
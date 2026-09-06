import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem115(Problem):
    def test(self) -> bool:
        s = "rabbbit"
        t = "rabbit"

        expected = 3

        result = self.numDistinct(s, t)

        print(result)

        return result == expected

    def numDistinct(self, s: str, t: str) -> int:
        n = len(s)
        m = len(t)
        if n < m:
            return 0
        dp = [0] * m
        for c in s:
            for i in range(m - 1, 0, -1):
                if t[i] == c:
                    dp[i] += dp[i - 1]
            if c == t[0]:
                dp[0] += 1

        return dp[m - 1]
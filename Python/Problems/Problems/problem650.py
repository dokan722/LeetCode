import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem650(Problem):
    def test(self) -> bool:
        n = 3

        expected = 3

        result = self.minSteps(n)

        print(result)

        return result == expected

    def minSteps(self, n: int) -> int:
        dp = [sys.maxsize] * (n + 1)
        dp[1] = 0
        for i in range(2, n + 1):
            for j in range(1, (i // 2) + 1):
                if i % j == 0:
                    dp[i] = min(dp[i], dp[j] + i // j)

        return dp[n]
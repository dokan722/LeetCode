import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2466(Problem):
    def test(self) -> bool:
        low = 2
        high = 3
        zero = 1
        one = 2

        expected = 5

        result = self.countGoodStrings(low, high, zero, one)

        print(result)

        return result == expected

    def countGoodStrings(self, low: int, high: int, zero: int, one: int) -> int:
        dp = [0] * (high + 1)
        dp[0] = 1
        big = max(zero, one)
        smal = min(zero, one)
        mod = 1000000007
        result = 0
        for i in range(smal, high + 1):
            dp[i] += dp[i - smal] % mod
            if i >= big:
                dp[i] += dp[i - big] % mod
            if i >= low:
                result = (result + dp[i]) % mod

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3699(Problem):
    def test(self) -> bool:
        n = 3
        l = 4
        r = 5

        expected = 2

        result = self.zigZagArrays(n, l, r)

        print(result)

        return result == expected

    def zigZagArrays(self, n: int, l: int, r: int) -> int:
        dp0 = [0] * (r + 1)
        dp1 = [0] * (r + 1)
        sum0 = [0] * (r + 2)
        sum1 = [0] * (r + 2)
        mod = 1000000007

        for i in range(1, r + 1):
            dp0[i] = 1
            dp1[i] = 1
            sum0[i] = i - l + 1
            sum1[i] = i - l + 1

        for i in range(1, n):
            for j in range(l, r + 1):
                dp0[j] = (sum1[r] - sum1[j] + mod) % mod
                dp1[j] = sum0[j - 1]

            sum0[l] = dp0[l]
            sum1[l] = dp1[l]
            for j in range(l + 1, r + 1):
                sum0[j] = (sum0[j - 1] + dp0[j]) %mod
                sum1[j] = (sum1[j - 1] + dp1[j]) %mod

        return (sum0[r] + sum1[r]) % mod
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2550(Problem):
    def test(self) -> bool:
        n = 3

        expected = 6

        result = self.monkeyMove(n)

        print(result)

        return result == expected

    def monkeyMove(self, n: int) -> int:
        result = 1
        b = 2
        mod = 1000000007
        while (n > 0):
            if n % 2 == 1:
                result = result * b % mod
            b = b * b % mod
            n //= 2

        return (result - 2 + mod) % mod
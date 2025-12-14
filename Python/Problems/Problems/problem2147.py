import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2147(Problem):
    def test(self) -> bool:
        corridor = "SSPPSPS"

        expected = 3

        result = self.numberOfWays(corridor)

        print(result)

        return result == expected

    def numberOfWays(self, corridor: str) -> int:
        n = len(corridor)
        result = 1
        chairs = 0
        mod = 1000000007
        i = 0
        while i < n:
            if corridor[i] == 'S':
                chairs += 1
            if chairs == 2:
                next = i + 1
                while next < n and corridor[next] != 'S':
                    next += 1
                if next < n:
                    result = result * (next - i) % mod
                    i = next
                    chairs = 1
            i += 1

        if chairs != 2:
            return 0

        return result
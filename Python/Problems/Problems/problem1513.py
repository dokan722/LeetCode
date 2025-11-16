import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1513(Problem):
    def test(self) -> bool:
        s = "0110111"

        expected = 9

        result = self.numSub(s)

        print(result)

        return result == expected

    def numSub(self, s: str) -> int:
        n = len(s)
        result = 0
        mod = 1000000007
        i = 0
        while i < n:
            if s[i] == '1':
                start = i
                while i < n and s[i] == '1':
                    i += 1
                l = i - start
                result += l * (l + 1) // 2 % mod
            i += 1

        return result
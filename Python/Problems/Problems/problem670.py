import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter, deque

from .problem import Problem


class Problem670(Problem):
    def test(self) -> bool:
        num = 2736

        expected = 7236

        result = self.maximumSwap(num)

        print(result)

        return result == expected

    def maximumSwap(self, num: int) -> int:
        s = str(num)
        n = len(s)
        for i in range(n):
            mx = i
            for j in range(i + 1, n):
                if s[j] > s[i] and s[j] >= s[mx]:
                    mx = j
            if i != mx:
                return int(s[0:i] + s[mx] + s[i + 1:mx] + s[i] + s[mx + 1:])

        return num
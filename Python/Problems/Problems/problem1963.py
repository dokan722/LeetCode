import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1963(Problem):
    def test(self) -> bool:
        s = "][]["

        expected = 1

        result = self.minSwaps(s)

        print(result)

        return result == expected

    def minSwaps(self, s: str) -> int:
        cur = 0
        result = 0
        for c in s:
            if c == ']':
                cur -= 1
            else:
                cur += 1
            if cur < 0:
                result += 1
                cur += 2

        return result
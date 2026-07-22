import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3499(Problem):
    def test(self) -> bool:
        s = "0100"

        expected = 4

        result = self.maxActiveSectionsAfterTrade(s)

        print(result)

        return result == expected

    def maxActiveSectionsAfterTrade(self, s: str) -> int:
        n = len(s)
        bs = "1" + s + "1"
        count = -1
        result = 0
        po = 0
        o = 0
        z = 0
        for i in range(1, n + 2):
            if bs[i] == '1':
                count += 1
            if bs[i - 1] == '1' and bs[i] == '0':
                po = o
                o = i
            elif bs[i - 1] == '0' and bs[i] == '1':
                if z != 0:
                    result = max(result, i - po - o + z)
                z = i
        return count + result
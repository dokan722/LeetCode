import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3628(Problem):
    def test(self) -> bool:
        s = "LMCT"

        expected = 2

        result = self.numOfSubsequences(s)

        print(result)

        return result == expected

    def numOfSubsequences(self, s: str) -> int:
        counts = Counter(s)
        ls = counts['L']
        cs = counts['C']
        ts = counts['T']
        count = 0
        bestc = 0
        bestl = 0
        bestt = 0
        curls = 0
        curcs = 0
        curts = 0
        for c in s:
            if c == 'L' or c == 'T':
                bestc = max(bestc, curls * (ts - curts));
                if c == 'L':
                    bestt += cs - curcs
                    curls += 1
                else:
                    bestl += curcs
                    curts += 1
            elif c == 'C':
                count += curls * (ts - curts)
                curcs += 1

        return max(count + bestc, max(count + bestl, count + bestt))
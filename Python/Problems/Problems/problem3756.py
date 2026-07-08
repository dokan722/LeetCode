import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3756(Problem):
    def test(self) -> bool:
        s = "10203004"
        queries = [[0, 7], [1, 3], [4, 6]]

        expected = [12340, 4, 9]

        result = self.sumAndMultiply(s, queries)

        print1DArray(result)

        return expected == result

    def sumAndMultiply(self, s: str, queries: List[List[int]]) -> List[int]:
        n = len(s)
        mod = 1000000007
        mods = [0] * (n + 1)
        sumPref = [0] * (n + 1)
        vals = [0] * (n + 1)
        lens = [0] * (n + 1)
        curMod = 1
        curVal = 0
        l = 0
        for i in range(1, n + 1):
            c = s[i - 1]
            curMod = (curMod * 10) % mod
            mods[i] = curMod
            sumPref[i] = sumPref[i - 1] + ord(c) - ord('0')
            if (c != '0'):
                curVal = (curVal * 10 + ord(c) - ord('0')) %mod
                l += 1
            vals[i] = curVal
            lens[i] = l

        m = len(queries)
        result = []
        for i in range(m):
            q = queries[i]
            val = (((vals[q[1] + 1] - vals[q[0]] * mods[lens[q[1] + 1] - lens[q[0]]]) % mod) + mod) % mod
            sm = sumPref[q[1] + 1] - sumPref[q[0]]
            result.append((val * sm) % mod)
        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2943(Problem):
    def test(self) -> bool:
        n = 2
        m = 3
        hBars = [2, 3]
        vBars = [2, 4]

        expected = 4

        result = self.maximizeSquareHoleArea(n, m, hBars, vBars)

        print(result)

        return result == expected

    def maximizeSquareHoleArea(self, n: int, m: int, hBars: List[int], vBars: List[int]) -> int:
        hBars.sort()
        vBars.sort()
        hn = len(hBars)
        vn = len(vBars)

        curr = 1
        hm = 1
        for i in range(1, hn):
            if hBars[i] == hBars[i - 1] + 1:
                curr += 1
            else:
                curr = 1
            hm = max(hm, curr)

        curr = 1
        vm = 1
        for i in range(1, vn):
            if vBars[i] == vBars[i - 1] + 1:
                curr += 1
            else:
                curr = 1
            vm = max(vm, curr)

        side = min(hm, vm) + 1

        return side * side
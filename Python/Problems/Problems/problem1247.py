import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1247(Problem):
    def test(self) -> bool:
        s1 = "xy"
        s2 = "yx"

        expected = 2

        result = self.minimumSwap(s1, s2)

        print(result)

        return expected == result

    def minimumSwap(self, s1: str, s2: str) -> int:
        n = len(s1)
        xs = 0
        ys = 0
        for i in range(n):
            if s1[i] == s2[i]:
                continue
            if s1[i] == 'x':
                xs += 1
            else:
                ys += 1

        if xs % 2 != ys % 2:
            return -1
        return (xs + ys) // 2 if xs % 2 == 0 else (ys + xs) // 2 + 1
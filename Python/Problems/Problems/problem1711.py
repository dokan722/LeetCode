import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1711(Problem):
    def test(self) -> bool:
        deliciousness = [1, 3, 5, 7, 9]

        expected = 4

        result = self.countPairs(deliciousness)

        print(result)

        return result == expected

    def countPairs(self, deliciousness: List[int]) -> int:
        pows = []
        pows.append(1)
        b = 2
        mod = 1000000007
        for i in range(22):
            pows.append(b)
            b <<= 1
        counts = dict()
        result = 0
        for d in deliciousness:
            for p in pows:
                exp = p - d
                if exp in counts:
                    result = (result + counts[exp]) %mod
            if d not in counts:
                counts[d] = 1
            else:
                counts[d] += 1

        return result
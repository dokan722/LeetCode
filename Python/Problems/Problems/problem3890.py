import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3890(Problem):
    def test(self) -> bool:
        n = 4104

        expected = [1729, 4104]

        result = self.findGoodIntegers(n)

        print1DArray(result)

        return expected == result

    def findGoodIntegers(self, n: int) -> list[int]:
        root = int(pow(n, 1.0 / 3))
        present = dict()
        res = []
        for i in range(1, root + 1):
            sf = i * i * i
            for j in range(i, root + 1):
                s = sf + j * j * j
                if s <= n:
                    if s in present and present[s] == 1:
                        res.append(s)
                        present[s] += 1
                    else:
                        present[s] = 1
                else:
                    break
        res.sort()

        return res
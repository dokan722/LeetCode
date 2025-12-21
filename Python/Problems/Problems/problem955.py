import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem955(Problem):
    def test(self) -> bool:
        strs = ["zyx", "wvu", "tsr"]

        expected = 3

        result = self.minDeletionSize(strs)

        print(result)

        return result == expected

    def minDeletionSize(self, strs: List[str]) -> int:
        n = len(strs)
        cols = len(strs[0])
        result = 0
        curr = [''] * n
        for i in range(cols):
            for j in range(n):
                curr[j] += strs[j][i]

            sorted = True
            for j in range(1, n):
                if curr[j - 1] > curr[j]:
                    sorted = False
                    break

            if not sorted:
                result += 1
                for j in range(n):
                    curr[j] = curr[j][:-1]

        return result
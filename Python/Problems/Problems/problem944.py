import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem944(Problem):
    def test(self) -> bool:
        strs = ["cba", "daf", "ghi"]

        expected = 1

        result = self.minDeletionSize(strs)

        print(result)

        return result == expected

    def minDeletionSize(self, strs: List[str]) -> int:
        n = len(strs)
        cols = len(strs[0])
        result = 0
        for i in range(cols):
            for j in range(1, n):
                if strs[j - 1][i] > strs[j][i]:
                    result += 1
                    break

        return result
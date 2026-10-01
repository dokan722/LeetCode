import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1111(Problem):
    def test(self) -> bool:
        seq = "(()())"

        expected = [0, 1, 0, 0, 1, 0]

        result = self.maxDepthAfterSplit(seq)

        print1DArray(result)

        return expected == result

    def maxDepthAfterSplit(self, seq: str) -> list[int]:
        n = len(seq)
        os = 0
        es = 0
        result = [0] * n
        for i in range(n):
            if seq[i] == '(':
                if (os & 1) == 1:
                    result[i] = 1
                os += 1
            else:
                if (es & 1) == 1:
                    result[i] = 1
                es += 1

        return result
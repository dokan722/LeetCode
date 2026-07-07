import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1072(Problem):
    def test(self) -> bool:
        matrix = [[0, 1], [1, 0]]

        expected = 2

        result = self.maxEqualRowsAfterFlips(matrix)

        print(result)

        return result == expected

    def maxEqualRowsAfterFlips(self, matrix: List[List[int]]) -> int:
        n = len(matrix)
        m = len(matrix[0])
        result = 0
        counts = dict()
        for i in range(n):
            pat1 = ""
            pat2 = ""
            for j in range(m):
                if matrix[i][j] == 0:
                    pat1 += "0"
                    pat2 += "1"
                else:
                    pat1 += "1"
                    pat2 += "0"
                if pat1 in counts:
                    counts[pat1] += 1
                else:
                    counts[pat1] = 1
                if pat2 in counts:
                    counts[pat2] += 1
                else:
                    counts[pat2] = 1
                result = max(result, max(counts[pat1], counts[pat2]))

        return result
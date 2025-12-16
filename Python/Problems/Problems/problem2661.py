import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2661(Problem):
    def test(self) -> bool:
        arr = [2, 8, 7, 4, 1, 3, 5, 6, 9]
        mat = [[3, 2, 5], [1, 4, 6], [8, 7, 9]]

        expected = 3

        result = self.firstCompleteIndex(arr, mat)

        print(result)

        return expected == result

    def firstCompleteIndex(self, arr: List[int], mat: List[List[int]]) -> int:
        n = len(mat)
        m = len(mat[0])
        nm = n * m
        pos = [[0, 0]] * (nm + 1)
        for i in range(n):
            for j in range(m):
                pos[mat[i][j]] = (i, j)

        rows = [0] * n
        cols = [0] * m
        for i in range(nm):
            p = pos[arr[i]]
            rows[p[0]] += 1
            cols[p[1]] += 1
            if rows[p[0]] == m or cols[p[1]] == n:
                return i

        return -1
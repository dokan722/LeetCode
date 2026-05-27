import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1314(Problem):
    def test(self) -> bool:
        mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
        k = 1

        expected = [[12, 21, 16], [27, 45, 33], [24, 39, 28]]

        result = self.matrixBlockSum(mat, k)

        print2DArray(result)

        return expected == result

    def matrixBlockSum(self, mat: List[List[int]], k: int) -> List[List[int]]:
        n = len(mat)
        m = len(mat[0])
        pref = [[0 for _ in range(m)] for _ in range(n)]
        result = [[0 for _ in range(m)] for _ in range(n)]
        for i in range(n):
            for j in range(m):
                left = pref[i - 1][j] if i > 0 else 0
                up = pref[i][j - 1] if j > 0 else 0
                ul = pref[i - 1][j - 1] if i > 0 and j > 0 else 0
                pref[i][j] = mat[i][j] + left + up - ul
        for i in range(n):
            for j in range(m):
                t = i - k - 1
                b = min(n - 1, i + k)
                l = j - k - 1
                r = min(m - 1, j + k)
                total = pref[b][r]
                left = pref[b][l] if l >= 0 else 0
                up = pref[t][r] if t >= 0 else 0
                ul = pref[t][l] if l >= 0 and t >= 0 else 0
                result[i][j] = total - left - up + ul

        return result
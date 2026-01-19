import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1292(Problem):
    def test(self) -> bool:
        mat = [[1, 1, 3, 2, 4, 3, 2], [1, 1, 3, 2, 4, 3, 2], [1, 1, 3, 2, 4, 3, 2]]
        threshold = 4

        expected = 2

        result = self.maxSideLength(mat, threshold)

        print(result)

        return result == expected

    def maxSideLength(self, mat: List[List[int]], threshold: int) -> int:
        n = len(mat)
        m = len(mat[0])
        pref = []
        for i in range(n + 1):
            pref.append([0] * (m + 1))
        for i in range(n):
            for j in range(m):
                pref[i + 1][j + 1] = mat[i][j] + pref[i][j + 1] + pref[i + 1][j] - pref[i][j]

        l = 0
        r = min(n, m)
        while l < r:
            mid = (l + r + 1) // 2
            possible = False
            horizontal = n - mid + 1
            vertical = m - mid + 1
            for i in range(horizontal):
                for j in range(vertical):
                    if pref[i + mid][j + mid] - pref[i + mid][j] - pref[i][j + mid] + pref[i][j] <= threshold:
                        possible = True
                        break
                if possible:
                    break

            if possible:
                l = mid
            else:
                r = mid - 1

        return l
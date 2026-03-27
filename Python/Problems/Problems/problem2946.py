import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2946(Problem):
    def test(self) -> bool:
        mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
        k = 4

        expected = False

        result = self.areSimilar(mat, k)

        print(result)

        return result == expected

    def areSimilar(self, mat: List[List[int]], k: int) -> bool:
        n = len(mat)
        m = len(mat[0])
        if k == m or k == 0:
            return True
        for i in range(n):
            for j in range(m):
                if i % 2 == 0:
                    if mat[i][j] != mat[i][((j - k) % m + m) % m]:
                        return False
                else:
                    if mat[i][j] != mat[i][(j + k) % m]:
                        return False

        return True
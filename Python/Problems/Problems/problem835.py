import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem835(Problem):
    def test(self) -> bool:
        img1 = [[1, 1, 0], [0, 1, 0], [0, 1, 0]]
        img2 = [[0, 0, 0], [0, 1, 1], [0, 0, 1]]

        expected = 3

        result = self.largestOverlap(img1, img2)

        print(result)

        return result == expected

    def largestOverlap(self, img1: List[List[int]], img2: List[List[int]]) -> int:
        n = len(img1)
        ss = 2 * n - 1
        result = [[0 for _ in range(ss)] for _ in range(ss)]
        for i in range(n):
            for j in range(n):
                if img2[i][j] == 0:
                    continue
                for k in range(ss):
                    for l in range(ss):
                        x = (i + k - n + 1)
                        y = (j + l - n + 1)
                        if x >= 0 and x < n and y >= 0 and y < n and img1[x][y] == 1:
                            result[k][l] += 1
        best = 0
        for i in range(ss):
            for j in range(ss):
                best = max(best, result[i][j])

        return best
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1975(Problem):
    def test(self) -> bool:
        matrix = [[1, -1], [-1, 1]]

        expected = 4

        result = self.maxMatrixSum(matrix)

        print(result)

        return result == expected

    def maxMatrixSum(self, matrix: List[List[int]]) -> int:
        m = sys.maxsize
        sum = 0
        even = True
        n = len(matrix)
        for i in range(n):
            for j in range(n):
                if matrix[i][j] < 0:
                    even = not even
                num = abs(matrix[i][j])
                m = min(m, num)
                sum += num

        return sum - (0 if even else 2 * m)
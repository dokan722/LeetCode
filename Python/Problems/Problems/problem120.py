from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem120(Problem):
    def test(self) -> bool:
        triangle = [[2], [3, 4], [6, 5, 7], [4, 1, 8, 3]]

        expected = 11

        result = self.minimumTotal(triangle)

        print(result)

        return expected == result

    def minimumTotal(self, triangle: List[List[int]]) -> int:
        n = len(triangle)
        for i in range(n - 2, -1, -1):
            for j in range(i + 1):
                triangle[i][j] += min(triangle[i + 1][j], triangle[i + 1][j + 1])

        return triangle[0][0]
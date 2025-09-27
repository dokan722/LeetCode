from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem812(Problem):
    def test(self) -> bool:
        points = [[0, 0], [0, 1], [1, 0], [0, 2], [2, 0]]

        expected = 2.0

        result = self.largestTriangleArea(points)

        print(result)

        return expected == result

    def largestTriangleArea(self, points: List[List[int]]) -> float:
        n = len(points)
        result = 0.0
        for i in range(n):
            for j in range(i + 1, n):
                for k in range(j + 1, n):
                    result = max(result, abs((points[j][0] - points[i][0]) * (points[k][1] - points[i][1])- (points[j][1] - points[i][1]) *(points[k][0] - points[i][0])) / 2.0)

        return result
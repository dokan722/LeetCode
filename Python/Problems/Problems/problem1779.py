import sys
from typing import List

from .problem import Problem

class Problem1779(Problem):
    def test(self) -> bool:
        x = 3
        y = 4

        points = [[1, 2], [3, 1], [2, 4], [2, 3], [4, 4]]

        expected = 2

        result = self.nearestValidPoint(x, y, points)

        print(result)

        return expected == result

    def nearestValidPoint(self, x: int, y: int, points: List[List[int]]) -> int:
        minDist = sys.maxsize
        result = -1
        for i in range(len(points)):
            if x != points[i][0] and y != points[i][1]:
                continue
            dist = abs(x - points[i][0]) + abs(y - points[i][1])
            if dist < minDist:
                result = i
                minDist = dist

        return result
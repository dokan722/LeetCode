import sys
from typing import List

from .problem import Problem


class Problem3025(Problem):
    def test(self) -> bool:
        points = [[3, 1], [1, 3], [1, 1]]

        expected = 2

        result = self.numberOfPairs(points)

        print(result)

        return result == expected

    def numberOfPairs(self, points: List[List[int]]) -> int:
        n = len(points)
        points.sort(key=lambda x: (-x[0], x[1]))
        result = 0

        for i in range(n - 1):
            maxX = sys.maxsize
            maxY = sys.maxsize
            for j in range(i + 1, n):
                if points[j][0] <= points[i][0] and points[j][1] >= points[i][1] and points[j][0] < maxX and points[j][1] < maxY:
                    result += 1
                    maxX = points[j][0]
                    maxY = points[j][1]

        return result


import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2463(Problem):
    def test(self) -> bool:
        robot = [0, 4, 6]
        factory = [[2, 2], [6, 2]]

        expected = 4

        result = self.minimumTotalDistance(robot, factory)

        print(result)

        return result == expected

    def minimumTotalDistance(self, robot: List[int], factory: List[List[int]]) -> int:
        robot.sort()
        factory.sort(key=lambda x: x[0])
        n = len(robot)
        m = len(factory)

        dp = [[int(1e18)] * (m + 1) for _ in range(n + 1)]
        for i in range(0, m + 1):
            dp[0][i] = 0

        for i in range(1, n + 1):
            for j in range(1, m + 1):
                dp[i][j] = dp[i][j - 1]
                newPos = factory[j - 1][0]
                newCap = factory[j - 1][1]
                acmDist = 0
                k = 1
                while k <= newCap and k <= i:
                    acmDist += abs(newPos - robot[i - k])
                    dp[i][j] = min(dp[i][j], acmDist + dp[i - k][j - 1])
                    k += 1

        return dp[n][m]
from typing import List
import math

from .problem import Problem

class Problem808(Problem):
    def test(self) -> bool:
        n = 100

        expected = 0.71875

        result = self.soupServings(n)

        print(result)

        return abs(result - expected) < 1e-5

    def soupServings(self, n: int) -> float:
        s = math.ceil(n / 25.0)
        if s >= 200:
            return 1
        dp = []
        for i in range(s+1):
            dp.append([-1] * (s + 1))

        return self.getProb(dp, s, s)

    def getProb(self, dp: List[List[float]], a: int, b: int) -> float:
        if a <= 0 and b <= 0:
            return 0.5
        if a <= 0:
            return 1
        if b <= 0:
            return 0
        if dp[a][b] < 0:
            dp[a][b] = 0.25 * (self.getProb(dp, a - 4, b) + self.getProb(dp, a - 3, b - 1) + self.getProb(dp, a - 2, b - 2) + self.getProb(dp,a - 1, b - 3))
        return dp[a][b]
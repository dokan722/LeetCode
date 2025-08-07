import sys
from typing import List

from .problem import Problem

class Problem3363(Problem):
    def test(self) -> bool:
        fruits = [[1, 2, 3, 4], [5, 6, 8, 7], [9, 10, 11, 12], [13, 14, 15, 16]]

        expected = 100

        result = self.maxCollectedFruits(fruits)

        print(result)

        return expected == result

    def maxCollectedFruits(self, fruits: List[List[int]]) -> int:
        n = len(fruits)
        diagonal = 0
        dp = []
        for i in range(n):
            diagonal += fruits[i][i]
            dp.append([-1] * n)


        dp[n - 1][n - 1] = 0
        lower = self.checkLower(fruits, dp, n, n - 1, 0, n - 1)
        upper = self.checkUpper(fruits, dp, n, 0, n - 1, n - 1)

        return diagonal + lower + upper

    def checkLower(self, fruits: List[List[int]], dp: List[List[int]], n: int, x: int, y: int, k: int):
        if x >= n or (k == 0 and x != y) or (k > 0 and x <= y):
            return -1
        if dp[x][y] != -1:
            return dp[x][y]

        best = max(max(self.checkLower(fruits, dp, n, x - 1, y + 1, k - 1), self.checkLower(fruits, dp, n, x, y + 1, k - 1)), self.checkLower(fruits, dp, n, x + 1, y + 1, k - 1))

        if best < 0:
            dp[x][y] = -sys.maxsize
        else:
            dp[x][y] = fruits[x][y] + best

        return dp[x][y]

    def checkUpper(self, fruits: List[List[int]], dp: List[List[int]], n: int, x: int, y: int, k: int):
        if y >= n or (k == 0 and x != y) or (k > 0 and x >= y):
            return -1
        if dp[x][y] != -1:
            return dp[x][y]

        best = max(max(self.checkUpper(fruits, dp, n, x + 1, y - 1, k - 1), self.checkUpper(fruits, dp, n, x + 1, y, k - 1)), self.checkUpper(fruits, dp, n, x + 1, y + 1, k - 1));

        if best < 0:
            dp[x][y] = -sys.maxsize
        else:
            dp[x][y] = fruits[x][y] + best

        return dp[x][y]



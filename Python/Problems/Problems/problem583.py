from typing import List

from .problem import Problem


class Problem583(Problem):
    def test(self) -> bool:
        word1 = "sea"
        word2 = "eat"

        expected = 2

        result = self.minDistance(word1, word2)

        print(result)

        return expected == result

    def minDistance(self, word1: str, word2: str) -> int:
        n = len(word1)
        m = len(word2)
        dp = []
        for i in range(n):
            dp.append([-1] * m)
        return self.minDistRec(dp, word1, word2, 0, 0)

    def minDistRec(self, dp: List[List[int]], word1: str, word2: str, i: int, j: int) -> int:
        if i >= len(word1):
            return len(word2) - j
        if j >= len(word2):
            return len(word1) - i
        if dp[i][j] != -1:
            return dp[i][j]
        result = 0
        if word1[i] == word2[j]:
            result = self.minDistRec(dp, word1, word2, i + 1, j + 1)
        else:
            result = min(self.minDistRec(dp, word1, word2, i + 1, j) + 1, self.minDistRec(dp, word1, word2, i, j + 1) + 1)
        dp[i][j] = result

        return result
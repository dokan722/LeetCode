from typing import List

from .problem import Problem

mod = 1000000007

class Problem1155(Problem):
    def test(self) -> bool:
        n = 30
        k = 30
        target = 500

        expected = 222616187

        result = self.numRollsToTarget(n, k, target)

        print(result)

        return expected == result

    def numRollsToTarget(self, n: int, k: int, target: int) -> int:
        dp = []
        for i in range(n + 1):
            dp.append([-1] * (target + 1))
        return self.numRollsRec(n, k, target, dp)

    def numRollsRec(self, n: int, k: int, target: int, dp: List[List[int]]) -> int:
        if n * k < target or n > target:
            return 0
        if target == n:
            return 1
        if n == 0:
            return 0

        if dp[n][target] != -1:
            return dp[n][target]

        result = 0
        for i in range(1, k + 1):
            result = (result + self.numRollsRec(n - 1, k, target - i, dp)) % mod
        dp[n][target] = result
        return dp[n][target]
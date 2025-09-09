from typing import List

from .problem import Problem


class Problem2327(Problem):
    def test(self) -> bool:
        n = 6
        delay = 2
        forget = 4

        expected = 5

        result = self.peopleAwareOfSecret(n, delay, forget)

        print(result)

        return result == expected

    def peopleAwareOfSecret(self, n: int, delay: int, forget: int) -> int:
        dp = [0] * n
        dp[0] = 1
        share = 0
        mod = 1000000007
        for i in range(1, n):
            if i - delay >= 0:
                share = (share + dp[i - delay] + mod) % mod
            if i - forget >= 0:
                share = (share - dp[i - forget] + mod) %mod
            dp[i] = share

        know = 0

        for i in range(n - forget, n):
            know = (know + dp[i]) % mod

        return know
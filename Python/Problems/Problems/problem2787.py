from typing import List, Dict

from .problem import Problem


class Problem2787(Problem):
    def test(self) -> bool:
        n = 64
        x = 3

        expected = 1

        result = self.numberOfWays(n, x)

        print(result)

        return result == expected

    def numberOfWays(self, n: int, x: int) -> int:
        mod = 1000000007
        poss = [0] * (n + 1)
        poss[0] = 1
        for i in range(1, n + 1):
            val = i ** x
            if val > n:
                break
            for j in range(n, val - 1, -1):
                poss[j] = (poss[j] + poss[j - val]) % mod

        return poss[n]
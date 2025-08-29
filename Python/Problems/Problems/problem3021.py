from typing import List

from .problem import Problem


class Problem3021(Problem):
    def test(self) -> bool:
        n = 3
        m = 2

        expected = 3

        result = self.flowerGame(n, m)

        print(result)

        return result == expected

    def flowerGame(self, n: int, m: int) -> int:
        nOdd = (n + 1) // 2
        nEven = n // 2
        mOdd = (m + 1) // 2
        mEven = m // 2

        return nOdd * mEven + nEven * mOdd
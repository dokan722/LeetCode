from typing import List, Dict

from .problem import Problem


class Problem326(Problem):
    def test(self) -> bool:
        n = 27

        expected = True

        result = self.isPowerOfThree(n)

        return expected == result

    def isPowerOfThree(self, n: int) -> bool:
        if n < 1:
            return False
        while n > 1:
            if n % 3 != 0:
                return False
            n /= 3

        return True
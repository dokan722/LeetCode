from typing import List, Dict

from .problem import Problem


class Problem342(Problem):
    def test(self) -> bool:
        n = 16

        expected = True

        result = self.isPowerOfFour(n)

        return expected == result

    def isPowerOfFour(self, n: int) -> bool:
        if n < 1:
            return False
        while n > 1:
            if n % 4 != 0:
                return False
            n /= 4

        return True
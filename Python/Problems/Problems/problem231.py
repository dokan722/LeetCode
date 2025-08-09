from typing import List

from .problem import Problem

class Problem231(Problem):
    def test(self) -> bool:
        n = 16

        expected = True

        result = self.isPowerOfTwo(n)

        return result == expected

    def isPowerOfTwo(self, n: int) -> bool:
        if n <= 0:
            return False

        while n > 1:
            mod = n % 2
            if mod == 1:
                return False
            n >>= 1

        return True
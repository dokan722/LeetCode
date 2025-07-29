import math
from typing import List, Dict

from .problem import Problem


class Problem2894(Problem):
    def test(self) -> bool:
        n = 10
        m = 3

        expected = 19

        result = self.differenceOfSums(n, m)

        print(result)

        return result == expected

    def differenceOfSums(self, n: int, m: int) -> int:
        num = math.floor(n / m)

        return int(((n * (n + 1) / 2)) - ((num * (num + 1)) / 2) * 2 * m)
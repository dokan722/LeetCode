from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2579(Problem):
    def test(self) -> bool:
        n = 2

        expected = 5

        result = self.coloredCells(n)

        print(result)

        return result == expected

    def coloredCells(self, n: int) -> int:
        return (n - 1) * n // 2 * 4 + 1
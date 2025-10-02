from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem791(Problem):
    def test(self) -> bool:
        order = "cba"
        s = "abcd"

        expected = "cbad"

        result = self.customSortString(order, s)

        print(result)

        return expected == result

    def customSortString(self, order: str, s: str) -> str:
        counts = Counter(s)

        result = ''
        for c in order:
            result += c * counts[c]
            counts[c] = 0

        for c, n in counts.items():
            result += c * n

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3871(Problem):
    def test(self) -> bool:
        n = 1002

        expected = 3

        result = self.countCommas(n)

        print(result)

        return result == expected

    def countCommas(self, n: int) -> int:
        result = 0
        i = 1000
        while i <= n:
            result += n - i + 1
            i *= 1000
        return result
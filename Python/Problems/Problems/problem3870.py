import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3870(Problem):
    def test(self) -> bool:
        n = 1002

        expected = 3

        result = self.countCommas(n)

        print(result)

        return result == expected

    def countCommas(self, n: int) -> int:
        return max(n - 999, 0)
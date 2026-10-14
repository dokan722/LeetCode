import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3723(Problem):
    def test(self) -> bool:
        num = 2
        sum = 3

        expected = "30"

        result = self.maxSumOfSquares(num, sum)

        print(result)

        return result == expected

    def maxSumOfSquares(self, num: int, sum: int) -> str:
        if 9 * num < sum:
            return ''
        nines = sum // 9
        rest = sum % 9
        zeros = num - nines - (0 if rest == 0 else 1)
        return '9' * nines + ('' if rest == 0 else str(rest)) + '0' * zeros
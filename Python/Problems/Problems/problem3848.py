import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3848(Problem):
    def test(self) -> bool:
        n = 145

        expected = True

        result = self.isDigitorialPermutation(n)

        return expected == result

    def isDigitorialPermutation(self, n: int) -> bool:
        factorials = [1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880]
        fs = 0
        counts = [0] * 10
        while n > 0:
            digit = n % 10
            fs += factorials[digit]
            counts[digit] += 1
            n //= 10

        while fs > 0:
            counts[fs % 10] -= 1
            fs //= 10
        for i in range(10):
            if counts[i] != 0:
                return False

        return True
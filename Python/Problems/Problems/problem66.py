import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem66(Problem):
    def test(self) -> bool:
        digits = [1, 2, 3]

        expected = [1, 2, 4]

        result = self.plusOne(digits)

        print1DArray(result)

        return result == expected

    def plusOne(self, digits: List[int]) -> List[int]:
        n = len(digits)
        i = n - 1
        while i >= 0 and digits[i] == 9:
            i -= 1
        if i == -1:
            result = [0] * (n + 1)
            result[0] = 1
            return result

        digits[i] += 1
        for j in range(i + 1, n):
            digits[j] = 0

        return digits
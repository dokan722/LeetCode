import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem762(Problem):
    def test(self) -> bool:
        left = 6
        right = 10

        expected = 4

        result = self.countPrimeSetBits(left, right)

        print(result)

        return result == expected

    def countPrimeSetBits(self, left: int, right: int) -> int:
        result = 0
        for i in range(left, right + 1):
            bits = i.bit_count()
            if  bits == 2 or bits == 3 or bits == 5 or bits == 7 or bits == 11 or bits == 13 or bits == 17 or bits == 19:
                result += 1

        return result
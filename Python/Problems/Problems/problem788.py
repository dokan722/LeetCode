import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem788(Problem):
    def test(self) -> bool:
        n = 10

        expected = 4

        result = (
            self.rotatedDigits(n))

        print(result)

        return result == expected

    def rotatedDigits(self, n: int) -> int:
        result = 0

        for i in range(1, n + 1):
            num = i
            changed = False
            while num > 0:
                r = num % 10
                if r == 3 or r == 4 or r == 7:
                    changed = False
                    break
                if r == 5 or r == 2 or r == 6 or r == 9:
                    changed = True
                num //= 10

            if changed:
                result += 1

        return result
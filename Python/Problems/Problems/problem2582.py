import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2582(Problem):
    def test(self) -> bool:
        n = 4
        time = 5

        expected = 2

        result = self.passThePillow(n, time)

        print(result)

        return result == expected

    def passThePillow(self, n: int, time: int) -> int:
        even = (time // (n - 1)) % 2 == 0
        return (time % (n - 1)) + 1 if even else n - (time % (n - 1))
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1780(Problem):
    def test(self) -> bool:
        n = 91

        expected = True

        result = self.checkPowersOfThree(n)

        return result == expected

    def checkPowersOfThree(self, n: int) -> bool:
        curr = 1
        while curr <= n:
            curr *= 3

        while n > 0:
            if n >= curr:
                n -= curr
            if n >= curr:
                return False
            curr /= 3

        return True
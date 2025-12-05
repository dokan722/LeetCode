import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1227(Problem):
    def test(self) -> bool:
        n = 2

        expected = 0.5

        result = self.nthPersonGetsNthSeat(n)

        print(result)

        return result == expected

    def nthPersonGetsNthSeat(self, n: int) -> float:
        if n == 1:
            return 1.0
        return 0.5
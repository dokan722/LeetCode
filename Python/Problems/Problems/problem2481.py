import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2481(Problem):
    def test(self) -> bool:
        n = 4

        expected = 2

        result = self.numberOfCuts(n)

        print(result)

        return result == expected

    def numberOfCuts(self, n: int) -> int:
        if n == 1:
            return 0
        return n // 2 if n % 2 == 0 else n
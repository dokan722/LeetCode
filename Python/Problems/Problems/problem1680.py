import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1680(Problem):
    def test(self) -> bool:
        n = 12

        expected = 505379714

        result = self.concatenatedBinary(n)

        print(result)

        return result == expected

    def concatenatedBinary(self, n: int) -> int:
        currPow = 2
        result = 0
        mod = 1000000007
        for i in range(1, n + 1):
            if currPow == i:
                currPow *= 2
            result = (result * currPow + i) % mod

        return result
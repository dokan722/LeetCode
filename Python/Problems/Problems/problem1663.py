import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1663(Problem):
    def test(self) -> bool:
        n = 5
        k = 73

        expected = "aaszz"

        result = self.getSmallestString(n, k)

        print(result)

        return result == expected

    def getSmallestString(self, n: int, k: int) -> str:
        result = ['a'] * n
        k -= n
        for i in range(n - 1, -1, -1):
            if k > 25:
                result[i] = 'z'
                k -= 25
            elif k != 0:
                result[i] = chr(ord('a') + k)
                break

        return ''.join(result)
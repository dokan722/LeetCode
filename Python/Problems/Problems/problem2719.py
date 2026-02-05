import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2719(Problem):
    def test(self) -> bool:
        s = "010101"

        expected = 9

        result = self.minimumCost(s)

        print(result)

        return result == expected

    def minimumCost(self, s: str) -> int:
        n = len(s)
        result = 0
        for i in range(1, n):
            if s[i - 1] != s[i]:
                result += min(i, n - i)
        return result
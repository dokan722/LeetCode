import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2222(Problem):
    def test(self) -> bool:
        s = "001101"

        expected = 6

        result = self.numberOfWays(s)

        print(result)

        return result == expected

    def numberOfWays(self, s: str) -> int:
        n = len(s)
        zeros = 0
        ones = 0
        zeroFirst = 0
        oneFirst = 0
        result = 0
        for i in range(n):
            if s[i] == '0':
                result += zeroFirst
                oneFirst += ones
                zeros += 1
            else:
                result += oneFirst
                zeroFirst += zeros
                ones += 1

        return result
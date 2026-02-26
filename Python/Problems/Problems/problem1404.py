import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1404(Problem):
    def test(self) -> bool:
        s = "1101"

        expected = 6

        result = self.numSteps(s)

        print(result)

        return result == expected

    def numSteps(self, s: str) -> int:
        n = len(s)
        carry = 0
        result = 0
        for i in range(n - 1, 0, -1):
            curr = 0 if s[i] == '0' else 1
            val = carry + curr
            carry = 1 if val != 0 else 0
            if val == 1:
                result += 2
            else:
                result += 1

        return result + carry
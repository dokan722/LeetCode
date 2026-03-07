import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1888(Problem):
    def test(self) -> bool:
        s = "111000"

        expected = 2

        result = self.minFlips(s)

        print(result)

        return result == expected

    def minFlips(self, s: str) -> int:
        n = len(s)
        op = [0, 0]

        for i in range(n):
            op[(ord(s[i]) ^ i) & 1] += 1

        res = min(op[0], op[1])

        for i in range(n - 1):
            op[(ord(s[i]) ^ i) & 1] -= 1
            op[(ord(s[i]) ^ (n + i)) & 1] += 1
            res = min(res, min(op[0], op[1]))

        return res
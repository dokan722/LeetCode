import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1653(Problem):
    def test(self) -> bool:
        s = "aababbab"

        expected = 2

        result = self.minimumDeletions(s)

        print(result)

        return result == expected

    def minimumDeletions(self, s: str) -> int:
        n = len(s)
        bs = 0
        dp = 0
        for i in range(n):
            if s[i] == 'b':
                bs += 1
            else:
                dp = min(dp + 1, bs)

        return dp
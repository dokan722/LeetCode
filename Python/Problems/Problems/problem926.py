import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem926(Problem):
    def test(self) -> bool:
        s = "00110"

        expected = 1

        result = self.minFlipsMonoIncr(s)

        print(result)

        return result == expected

    def minFlipsMonoIncr(self, s: str) -> int:
        ones = 0
        result = 0
        for c in s:
            if c == '1':
                ones += 1
            else:
                result = min(result + 1, ones)

        return result
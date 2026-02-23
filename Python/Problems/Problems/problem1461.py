import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1461(Problem):
    def test(self) -> bool:
        s = "00110110"
        k = 2

        expected = True

        result = self.hasAllCodes(s, k)

        return expected == result

    def hasAllCodes(self, s: str, k: int) -> bool:
        n = len(s)
        present = set()
        for i in range(n - k + 1):
            present.add(s[i:(i+k)])

        return (1 << k) == len(present)
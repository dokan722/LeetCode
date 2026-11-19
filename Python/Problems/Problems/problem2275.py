import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2275(Problem):
    def test(self) -> bool:
        candidates = [16, 17, 71, 62, 12, 24, 14]

        expected = 4

        result = self.largestCombination(candidates)

        print(result)

        return result == expected

    def largestCombination(self, candidates: list[int]) -> int:
        result = 0
        maxBits = 24
        for i in range(maxBits):
            cur = 0
            bit = 1 << i
            for num in candidates:
                if (num & bit) == bit:
                    cur += 1
            result = max(cur, result)

        return result
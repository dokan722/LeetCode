import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem274(Problem):
    def test(self) -> bool:
        citations = [3, 0, 6, 1, 5]

        expected = 3

        result = self.hIndex(citations)

        print(result)

        return result == expected

    def hIndex(self, citations: List[int]) -> int:
        counts = [0] * 1001
        for c in citations:
            counts[c] += 1

        cur = 0
        for i in range(1000, -1, -1):
            cur += counts[i]
            if cur >= i:
                return i

        return 0
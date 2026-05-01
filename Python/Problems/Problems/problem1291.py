import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1291(Problem):
    def test(self) -> bool:
        low = 100
        high = 300

        expected = [123, 234]

        result = self.sequentialDigits(low, high)

        print1DArray(result)

        return expected == result

    def sequentialDigits(self, low: int, high: int) -> List[int]:
        result = []
        for i in range(1, 10):
            num = 0
            for j in range(i, 10):
                num *= 10
                num += j
                if num < low:
                    continue
                if num <= high:
                    result.append(num)
                else:
                    break

        result.sort()
        return result
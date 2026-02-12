import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2001(Problem):
    def test(self) -> bool:
        rectangles = [[4, 8], [3, 6], [10, 20], [15, 30]]

        expected = 6

        result = self.interchangeableRectangles(rectangles)

        print(result)

        return result == expected

    def interchangeableRectangles(self, rectangles: List[List[int]]) -> int:
        counts = dict()
        result = 0
        for r in rectangles:
            val = str(r[0] / r[1])
            if val in counts:
                result += counts[val]
                counts[val] += 1
            else:
                counts[val] = 1

        return result
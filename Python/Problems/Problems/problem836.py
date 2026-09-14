import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem836(Problem):
    def test(self) -> bool:
        rec1 = [0, 0, 2, 2]
        rec2 = [1, 1, 3, 3]

        expected = True

        result = self.isRectangleOverlap(rec1, rec2)

        return result == expected

    def isRectangleOverlap(self, rec1: List[int], rec2: List[int]) -> bool:
        return rec1[0] < rec2[2] and rec1[2] > rec2[0] and rec1[1] < rec2[3] and rec1[3] > rec2[1]
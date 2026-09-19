import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1401(Problem):
    def test(self) -> bool:
        radius = 1
        xCenter = 0
        yCenter = 0
        x1 = 1
        y1 = -1
        x2 = 3
        y2 = 1

        expected = True

        result = self.checkOverlap(radius, xCenter, yCenter, x1, y1, x2, y2)

        return expected == result

    def checkOverlap(self, radius: int, xCenter: int, yCenter: int, x1: int, y1: int, x2: int, y2: int) -> bool:
        dx = max(x1, min(xCenter, x2)) - xCenter
        dy = max(y1, min(yCenter, y2)) - yCenter

        return dx * dx + dy * dy <= radius * radius
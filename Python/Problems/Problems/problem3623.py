import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3623(Problem):
    def test(self) -> bool:
        points = [[1, 0], [2, 0], [3, 0], [2, 2], [3, 2]]

        expected = 3

        result = self.countTrapezoids(points)

        print(result)

        return result == expected

    def countTrapezoids(self, points: List[List[int]]) -> int:
        counts = dict()
        mod = 1000000007
        for point in points:
            if point[1] in counts:
                counts[point[1]] += 1
            else:
                counts[point[1]] = 1

        s = 0
        result = 0
        for count in counts.values():
            pairs = count * (count - 1) // 2
            result = (result + pairs * s) % mod
            s = (s + pairs) % mod

        return result
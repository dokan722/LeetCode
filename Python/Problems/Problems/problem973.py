import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem973(Problem):
    def test(self) -> bool:
        points = [[1, 3], [-2, 2]]
        k = 1

        expected = [[-2, 2]]

        result = self.kClosest(points, k)

        print2DArray(result)

        return expected == result

    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        points.sort(key= lambda x: x[0] * x[0] + x[1] * x[1])
        return points[:k]
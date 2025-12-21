import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3285(Problem):
    def test(self) -> bool:
        height = [1, 2, 3, 4, 5]
        threshold = 2
        expected = [3, 4]

        result = self.stableMountains(height, threshold)

        print1DArray(result)

        return expected == result

    def stableMountains(self, height: List[int], threshold: int) -> List[int]:
        n = len(height)
        result = []
        for i in range(n - 1):
            if height[i] > threshold:
                result.append(i + 1)

        return result
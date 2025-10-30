import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1526(Problem):
    def test(self) -> bool:
        target = [3, 1, 5, 4, 2]

        expected = 7

        result = self.minNumberOperations(target)

        print(result)

        return expected == result

    def minNumberOperations(self, target: List[int]) -> int:
        n = len(target)
        result = target[0]
        for i in range(1, n):
            result += max(0, target[i] - target[i - 1])

        return result
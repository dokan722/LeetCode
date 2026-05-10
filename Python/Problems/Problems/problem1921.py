import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1921(Problem):
    def test(self) -> bool:
        dist = [1, 3, 4]
        speed = [1, 1, 1]

        expected = 3

        result = self.eliminateMaximum(dist, speed)

        print(result)

        return result == expected

    def eliminateMaximum(self, dist: List[int], speed: List[int]) -> int:
        n = len(dist)
        turn = [(dist[i] + speed[i] - 1) // speed[i] for i in range(n)]
        turn.sort()
        for i in range(n):
            if turn[i] < i + 1:
                return i

        return n
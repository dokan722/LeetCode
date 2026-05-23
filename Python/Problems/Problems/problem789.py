import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem789(Problem):
    def test(self) -> bool:
        ghosts = [[1, 0], [0, 3]]
        target = [0, 1]

        expected = True

        result = self.escapeGhosts(ghosts, target)

        return result == expected

    def escapeGhosts(self, ghosts: List[List[int]], target: List[int]) -> bool:
        dist = abs(target[0]) + abs(target[1])
        for g in ghosts:
            if dist >= abs(target[0] - g[0]) + abs(target[1] - g[1]):
                return False

        return True
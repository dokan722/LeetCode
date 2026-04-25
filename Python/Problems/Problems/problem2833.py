import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2833(Problem):
    def test(self) -> bool:
        moves = "L_RL__R"

        expected = 3

        result = self.furthestDistanceFromOrigin(moves)

        print(result)

        return result == expected

    def furthestDistanceFromOrigin(self, moves: str) -> int:
        left = moves.count("L")
        right = moves.count("R")
        wild = moves.count("_")

        return abs(left - right) + wild
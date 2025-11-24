import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3222(Problem):
    def test(self) -> bool:
        x = 2
        y = 7

        expected = "Alice"

        result = self.winningPlayer(x, y)

        print(result)

        return expected == result

    def winningPlayer(self, x: int, y: int) -> str:
        yTurns = y // 4
        return "Bob" if min(x, yTurns) % 2 == 0 else "Alice"
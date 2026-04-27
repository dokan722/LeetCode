import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1033(Problem):
    def test(self) -> bool:
        a = 1
        b = 2
        c = 5

        expected = [1, 2]

        result = self.numMovesStones(a, b, c)

        print(result)

        return expected == result

    def numMovesStones(self, a: int, b: int, c: int) -> List[int]:
        s = [a, b, c]
        s.sort()
        left = s[1] - s[0] - 1
        right = s[2] - s[1] - 1
        m = 2
        if left == 0 and right == 0:
            m = 0
        elif left < 2 or right < 2:
            m = 1

        return [m, left + right]
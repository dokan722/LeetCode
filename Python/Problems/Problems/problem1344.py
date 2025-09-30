from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1344(Problem):
    def test(self) -> bool:
        hour = 12
        minutes = 30

        expected = 165

        result = self.angleClock(hour, minutes)

        print(result)

        return abs(result - expected) < 1e-5

    def angleClock(self, hour: int, minutes: int) -> float:
        angle = abs(hour * 30 + minutes / 2.0 - minutes * 6)
        return angle if angle < 180 else 360 - angle
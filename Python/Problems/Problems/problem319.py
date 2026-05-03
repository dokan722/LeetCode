import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem319(Problem):
    def test(self) -> bool:
        n = 3

        expected = 1

        result = self.bulbSwitch(n)

        print(result)

        return result == expected

    def bulbSwitch(self, n: int) -> int:
        return int(math.sqrt(n))
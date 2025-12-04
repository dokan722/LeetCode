import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2211(Problem):
    def test(self) -> bool:
        directions = "RLRSLL"

        expected = 5

        result = self.countCollisions(directions)

        print(result)

        return result == expected

    def countCollisions(self, directions: str) -> int:
        n = len(directions)
        start = 0
        end = n - 1
        while start < n and directions[start] == 'L':
            start += 1
        while end >= 0 and directions[end] == 'R':
            end -= 1
        result = 0
        for i in range(start, end + 1):
            if directions[i] != 'S':
                result += 1
        return result
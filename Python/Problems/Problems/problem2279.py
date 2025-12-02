import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2279(Problem):
    def test(self) -> bool:
        capacity = [2, 3, 4, 5]
        rocks = [1, 2, 4, 4]
        additionalRocks = 2

        expected = 3

        result = self.maximumBags(capacity, rocks, additionalRocks)

        print(result)

        return result == expected

    def maximumBags(self, capacity: List[int], rocks: List[int], additionalRocks: int) -> int:
        n = len(capacity)
        space = [cap - rock for (cap, rock) in zip(capacity, rocks)]
        space.sort()
        result = 0
        for i in range(n):
            if space[i] == 0 or additionalRocks >= space[i]:
                additionalRocks -= space[i]
                result += 1
            else:
                return result

        return result
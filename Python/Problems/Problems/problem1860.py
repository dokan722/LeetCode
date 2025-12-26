import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1860(Problem):
    def test(self) -> bool:
        memory1 = 8
        memory2 = 11

        expected = [6, 0, 4]

        result = self.memLeak(memory1, memory2)

        print1DArray(result)

        return expected == result

    def memLeak(self, memory1: int, memory2: int) -> List[int]:
        n = memory1 + memory2 + 2
        for i in range(1, n):
            if memory1 >= memory2:
                if memory1 < i:
                    return [i, memory1, memory2]
                memory1 -= i
            else:
                if memory2 < i:
                    return [i, memory1, memory2]
                memory2 -= i

        return None
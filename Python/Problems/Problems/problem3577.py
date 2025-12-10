import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3577(Problem):
    def test(self) -> bool:
        complexity = [1, 2, 3]

        expected = 2

        result = self.countPermutations(complexity)

        print(result)

        return result == expected

    def countPermutations(self, complexity: List[int]) -> int:
        n = len(complexity)
        mod = 1000000007
        for i in range(1, n):
            if complexity[i] <= complexity[0]:
                return 0
        result = 1
        for i in range(1, n):
            result = (result * i) % mod

        return result
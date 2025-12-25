import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3075(Problem):
    def test(self) -> bool:
        happiness = [1, 2, 3]
        k = 2

        expected = 4

        result = self.maximumHappinessSum(happiness, k)

        print(result)

        return result == expected

    def maximumHappinessSum(self, happiness: List[int], k: int) -> int:
        n = len(happiness)
        happiness.sort()

        result = 0
        for i in range(k):
            result += max(0, happiness[n - i - 1] - i)

        return result
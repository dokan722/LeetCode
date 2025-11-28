import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2951(Problem):
    def test(self) -> bool:
        mountain = [1, 4, 3, 8, 5]

        expected = [1, 3]

        result = self.findPeaks(mountain)

        print1DArray(result)

        return result == expected

    def findPeaks(self, mountain: List[int]) -> List[int]:
        n = len(mountain)
        result = []
        for i in range(1, n - 1):
            if mountain[i] > mountain[i - 1] and mountain[i] > mountain[i + 1]:
                result.append(i)

        return result
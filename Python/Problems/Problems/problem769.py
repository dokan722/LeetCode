import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem769(Problem):
    def test(self) -> bool:
        arr = [1, 0, 2, 3, 4]

        expected = 4

        result = self.maxChunksToSorted(arr)

        print(result)

        return result == expected

    def maxChunksToSorted(self, arr: List[int]) -> int:
        n = len(arr)
        m = -1
        result = 0
        for i in range(n):
            m = max(arr[i], m)
            if m == i:
                result += 1

        return result


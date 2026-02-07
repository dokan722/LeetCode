import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1846(Problem):
    def test(self) -> bool:
        arr = [2, 2, 1, 2, 1]

        expected = 2

        result = self.maximumElementAfterDecrementingAndRearranging(arr)

        print(result)

        return result == expected

    def maximumElementAfterDecrementingAndRearranging(self, arr: List[int]) -> int:
        n = len(arr)
        arr.sort()
        th = 1
        for i in range(n):
            th = min(th + 1, arr[i])
        return th
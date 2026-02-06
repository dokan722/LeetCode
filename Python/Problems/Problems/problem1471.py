import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1471(Problem):
    def test(self) -> bool:
        arr = [6, 7, 11, 7, 6, 8]
        k = 5

        expected = [11, 8, 6, 6, 7]

        result = self.getStrongest(arr, k)

        print1DArray(result)

        return expected == result

    def getStrongest(self, arr: List[int], k: int) -> List[int]:
        n = len(arr)
        if k == n:
            return arr
        arr.sort()
        result = []
        m = arr[(n - 1) // 2]
        left = 0
        right = n - 1
        for i in range(k):
            if abs(m - arr[left]) > abs(m - arr[right]):
                result.append(arr[left])
                left += 1
            else:
                result.append(arr[right])
                right -= 1

        return result
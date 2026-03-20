import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem658(Problem):
    def test(self) -> bool:
        arr = [0, 0, 1, 2, 3, 3, 4, 7, 7, 8]
        k = 3
        x = 5

        expected = [3, 3, 4]

        result = self.findClosestElements(arr, k, x)

        print1DArray(result)

        return expected == result

    def findClosestElements(self, arr: List[int], k: int, x: int) -> List[int]:
        n = len(arr)
        if n == k:
            return arr
        l = 0
        r = n - 1
        while l < r:
            mid = (l + r) // 2
            if arr[mid] >= x:
                r = mid
            else:
                l = mid + 1

        if arr[l] > x:
            l -= 1
        r = l + 1
        result = []
        for i in range(k):
            if r >= n:
                l -= 1
            elif l < 0:
                r += 1
            else:
                if abs(arr[l] - x) > abs(arr[r] - x):
                    r += 1
                else:
                    l -= 1
        for i in range(1, k + 1):
            result.append(arr[l + i])

        return result
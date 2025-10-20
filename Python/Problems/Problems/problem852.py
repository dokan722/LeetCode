import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem852(Problem):
    def test(self) -> bool:
        arr = [0, 10, 5, 2]

        expected = 1

        result = self.peakIndexInMountainArray(arr)

        print(result)

        return expected == result

    def peakIndexInMountainArray(self, arr: List[int]) -> int:
        left = 0
        right = len(arr) - 1
        while left < right:
            mid = (left + right) // 2
            if arr[mid] < arr[mid + 1]:
                left = mid + 1
            else:
                right = mid

        return left
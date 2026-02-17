import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1186(Problem):
    def test(self) -> bool:
        arr = [1, -2, -2, 3]

        expected = 3

        result = self.maximumSum(arr)

        print(result)

        return result == expected

    def maximumSum(self, arr: List[int]) -> int:
        n = len(arr)
        all = arr[0]
        delete = arr[0]
        result = arr[0]
        for i in range(1, n):
            delete = max(all, delete + arr[i])
            all = max(all + arr[i], arr[i])
            result = max(result, max(all, delete))

        return result
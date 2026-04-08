import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1299(Problem):
    def test(self) -> bool:
        arr = [17, 18, 5, 4, 6, 1]

        expected = [18, 6, 6, 6, 1, -1]

        result = self.replaceElements(arr)

        print1DArray(result)

        return expected == result

    def replaceElements(self, arr: List[int]) -> List[int]:
        n = len(arr)
        mx = arr[n - 1]
        arr[n - 1] = -1
        for i in range(n - 2, -1, -1):
            tmp = arr[i]
            arr[i] = mx
            mx = max(mx, tmp)

        return arr
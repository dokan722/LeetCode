import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem978(Problem):
    def test(self) -> bool:
        arr = [9, 4, 2, 10, 7, 8, 8, 1, 9]

        expected = 5

        result = self.maxTurbulenceSize(arr)

        print(result)

        return result == expected

    def maxTurbulenceSize(self, arr: List[int]) -> int:
        n = len(arr)
        result = 1
        cur = [1, 1]
        for i in range(1, n):
            if i % 2 == 0:
                if arr[i] < arr[i - 1]:
                    cur[0] += 1
                    cur[1] = 1
                elif arr[i] > arr[i - 1]:
                    cur[0] = 1
                    cur[1] += 1
                else:
                    cur[0] = 1
                    cur[1] = 1
            else:
                if arr[i] < arr[i - 1]:
                    cur[0] = 1
                    cur[1] += 1
                elif arr[i] > arr[i - 1]:
                    cur[0] += 1
                    cur[1] = 1
                else:
                    cur[0] = 1
                    cur[1] = 1
            result = max(result, max(cur[0], cur[1]))

        return result
import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3424(Problem):
    def test(self) -> bool:
        arr = [-7, 9, 5]
        brr = [7, -2, -5]
        k = 2

        expected = 13

        result = self.minCost(arr, brr, k)

        print(result)

        return result == expected

    def minCost(self, arr: List[int], brr: List[int], k: int) -> int:
        n = len(arr)
        sortedResult = k
        unsortedResult = 0
        sorted = arr.copy()
        sorted.sort()
        order = [i for i in range(n)]
        order.sort(key=lambda x: brr[x])
        for i in range(n):
            sortedResult += abs(sorted[i] - brr[order[i]])
            unsortedResult += abs(arr[i] - brr[i])

        return min(sortedResult, unsortedResult)
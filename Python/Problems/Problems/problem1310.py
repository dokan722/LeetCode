import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1310(Problem):
    def test(self) -> bool:
        arr = [1, 3, 4, 8]
        queries = [[0, 1], [1, 2], [0, 3], [3, 3]]

        expected = [2, 7, 14, 8]

        result = self.xorQueries(arr, queries)

        print1DArray(result)

        return expected == result

    def xorQueries(self, arr: List[int], queries: List[List[int]]) -> List[int]:
        n = len(arr)
        pref = [0]
        for i in range(n):
            pref.append(pref[i] ^ arr[i])
        m = len(queries)
        result = []
        for i in range(m):
            result.append(pref[queries[i][0]] ^ pref[queries[i][1] + 1])

        return result
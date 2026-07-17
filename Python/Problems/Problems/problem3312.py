import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3312(Problem):
    def test(self) -> bool:
        nums = [2, 3, 4]
        queries = [0, 2, 2]

        expected = [1, 2, 2]

        result = self.gcdValues(nums, queries)

        print1DArray(result)

        return expected == result

    def gcdValues(self, nums: List[int], queries: List[int]) -> List[int]:
        n = len(nums)
        mx = 0
        for i in range(n):
            mx = max(mx, nums[i])
        freqs = [0] * (mx + 1)
        for i in range(n):
            freqs[nums[i]] += 1
        gcds = [0] * (mx + 1)
        for i in range(mx, 0, -1):
            pairs = 0
            bigger = 0
            for j in range(i, mx + 1, i):
                pairs += freqs[j]
                bigger += gcds[j]
            gcds[i] = pairs * (pairs - 1) / 2 - bigger
        for i in range(1, mx + 1):
            gcds[i] += gcds[i - 1]
        m = len(queries)
        result = []

        for i in range(m):
            l = 0
            r = mx
            val = queries[i] + 1
            while l < r:
                mid = (l + r) // 2
                if gcds[mid] < val:
                    l = mid + 1
                else:
                    r = mid

            result.append(l)

        return result
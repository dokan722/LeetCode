import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3904(Problem):
    def test(self) -> bool:
        nums = [5, 0, 1, 4]
        k = 3

        expected = 3

        result = self.firstStableIndex(nums, k)

        print(result)

        return result == expected

    def firstStableIndex(self, nums: list[int], k: int) -> int:
        n = len(nums)
        mins = [0] * n
        mins[n - 1] = nums[n - 1]
        for i in range(n - 2, -1, -1):
            mins[i] = min(nums[i], mins[i + 1])

        mx = -1
        for i in range(n):
            mx = max(mx, nums[i])
            if mx - mins[i] <= k:
                return i

        return -1
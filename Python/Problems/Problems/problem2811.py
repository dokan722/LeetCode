import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2811(Problem):
    def test(self) -> bool:
        nums = [2, 2, 1]
        m = 4

        expected = True

        result = self.canSplitArray(nums, m)

        return result == expected

    def canSplitArray(self, nums: List[int], m: int) -> bool:
        n = len(nums)
        if n < 3:
            return True
        for i in range(1, n):
            if nums[i - 1] + nums[i] >= m:
                return True

        return False
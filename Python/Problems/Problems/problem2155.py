import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2155(Problem):
    def test(self) -> bool:
        nums = [0, 0, 1, 0]

        expected = [4, 2]

        result = self.maxScoreIndices(nums)

        print1DArray(result)

        return expected == result

    def maxScoreIndices(self, nums: List[int]) -> List[int]:
        n = len(nums)
        zeros = []
        cur = 0
        for i in range(n):
            zeros.append(cur)
            if (nums[i] == 0):
                cur += 1
        result = [n]
        mx = cur
        cur = 0
        for i in range(n - 1, -1, -1):
            if nums[i] == 1:
                cur += 1
            val = cur + zeros[i]
            if val > mx:
                mx = val
                result = [i]
            elif val == mx:
                result.append(i)

        return result
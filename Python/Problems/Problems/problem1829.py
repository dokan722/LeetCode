import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1829(Problem):
    def test(self) -> bool:
        nums = [0, 1, 1, 3]
        maximumBit = 2

        expected = [0, 3, 2, 3]

        result = self.getMaximumXor(nums, maximumBit)

        print1DArray(result)

        return expected == result

    def getMaximumXor(self, nums: List[int], maximumBit: int) -> List[int]:
        n = len(nums)
        cur = 0
        result = [0] * n
        mask = (1 << maximumBit) - 1
        for i in range(n):
            cur ^= nums[i]
            result[n - 1 - i] = (mask ^ cur)
        return result
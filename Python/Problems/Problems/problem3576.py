import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3576(Problem):
    def test(self) -> bool:
        nums = [1, -1, 1, -1, 1]
        k = 3

        expected = True

        result = self.canMakeEqual(nums, k)

        return result == expected

    def canMakeEqual(self, nums: List[int], k: int) -> bool:
        n = len(nums)
        opsNeg = 0
        opsPos = 0
        nextNeg = nums[0]
        nextPos = nums[0]
        for i in range(n - 1):
            if nextPos == -1:
                nextPos = nums[i + 1] * -1
                opsPos += 1
            else:
                nextPos = nums[i + 1]
            if nextNeg == 1:
                nextNeg = nums[i + 1] * -1
                opsNeg += 1
            else:
                nextNeg = nums[i + 1]
            if opsPos > k and opsNeg > k:
                return False

        return (opsPos <= k and nextPos == 1) or (opsNeg <= k and nextNeg == -1)
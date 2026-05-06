import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2420(Problem):
    def test(self) -> bool:
        nums = [2, 1, 1, 1, 3, 4, 1]
        k = 2

        expected = [2, 3]

        result = self.goodIndices(nums, k)

        print1DArray(result)

        return expected == result

    def goodIndices(self, nums: List[int], k: int) -> List[int]:
        n = len(nums)
        to = [0] * n
        cur = 1
        for i in range(n - 2, -1, -1):
            to[i] = cur
            if nums[i] <= nums[i + 1]:
                cur += 1
            else:
                cur = 1
        result = []
        cur = 1
        for i in range(1, n):
            if to[i] >= k and cur >= k:
                result.append(i)
            if nums[i - 1] >= nums[i]:
                cur += 1
            else:
                cur = 1

        return result
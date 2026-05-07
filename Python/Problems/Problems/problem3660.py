import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3660(Problem):
    def test(self) -> bool:
        nums = [2, 1, 3]

        expected = [2, 2, 3]

        result = self.maxValue(nums)

        print1DArray(result)

        return expected == result

    def maxValue(self, nums: List[int]) -> List[int]:
        n = len(nums)
        mx = 0
        leftMax = [0] * n
        for i in range(n):
            mx = max(nums[i], mx)
            leftMax[i] = mx
        result = [0] * n
        result[n - 1] = leftMax[n - 1]
        mn = nums[n - 1]
        for i in range(n - 2, -1, -1):
            if mn < leftMax[i]:
                result[i] = result[i + 1]
            else:
                result[i] = leftMax[i]
            mn = min(mn, nums[i])

        return result
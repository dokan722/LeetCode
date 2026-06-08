import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3584(Problem):
    def test(self) -> bool:
        nums = [-1, -9, 2, 3, -2, -3, 1]
        m = 1

        expected = 81

        result = self.maximumProduct(nums, m)

        print(result)

        return result == expected

    def maximumProduct(self, nums: List[int], m: int) -> int:
        n = len(nums)
        mx = -sys.maxsize
        mn = sys.maxsize
        result = -sys.maxsize
        for i in range(m - 1, n):
            last = i - (m - 1)
            mx = max(mx, nums[last])
            mn = min(mn, nums[last])
            result = max(result, max(nums[i] * mx, nums[i] * mn))

        return result
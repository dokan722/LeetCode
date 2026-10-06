import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3979(Problem):
    def test(self) -> bool:
        nums = [1, 3, 5, 2, 8]
        k = 2

        expected = 13

        result = self.maxValidPairSum(nums, k)

        print(result)

        return result == expected

    def maxValidPairSum(self, nums: list[int], k: int) -> int:
        n = len(nums)
        mx = nums[0]
        result = 0
        for i in range(n - k):
            mx = max(mx, nums[i])
            result = max(result, mx + nums[i + k])

        return result
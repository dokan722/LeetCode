import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem713(Problem):
    def test(self) -> bool:
        nums = [10, 5, 2, 6]
        k = 100

        expected = 8

        result = self.numSubarrayProductLessThanK(nums, k)

        print(result)

        return result == expected

    def numSubarrayProductLessThanK(self, nums: List[int], k: int) -> int:
        if k < 2:
            return 0
        n = len(nums)
        l = 0
        result = 0
        cur = 1
        for i in range(n):
            cur *= nums[i]
            while l < n and cur >= k:
                cur //= nums[l]
                l += 1
            result += i - l + 1

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3942(Problem):
    def test(self) -> bool:
        nums = [0, 2, 1]

        expected = 2

        result = self.minOperations(nums)

        print(result)

        return result == expected

    def minOperations(self, nums: List[int]) -> int:
        n = len(nums)
        if n == 1:
            return 0
        zero = 0
        for i in range(1, n):
            diff = abs(nums[i] - nums[i - 1])
            if diff != 1 and diff != n - 1:
                return -1
            if nums[i] == 0:
                zero = i

        if nums[(zero + 1) % n] - nums[zero] == 1:
            return min(zero, n - 1 - zero + 3)

        return min(n - 1 - zero + 1, zero + 2)
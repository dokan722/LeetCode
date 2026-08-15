import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3974(Problem):
    def test(self) -> bool:
        nums = [6, 1, 2, 9]
        k = 3
        mul = 2

        expected = 26

        result = self.maxSum(nums, k, mul)

        print(result)

        return result == expected

    def maxSum(self, nums: list[int], k: int, mul: int) -> int:
        n = len(nums)
        nums.sort()
        result = 0
        for i in range(k):
            if mul > 1:
                result += nums[n - i - 1] * mul
                mul -= 1
            else:
                result += nums[n - i - 1]

        return result
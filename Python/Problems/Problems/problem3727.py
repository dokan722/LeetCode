import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3727(Problem):
    def test(self) -> bool:
        nums = [1, -1, 2, -2, 3, -3]

        expected = 16

        result = self.maxAlternatingSum(nums)

        print(result)

        return result == expected

    def maxAlternatingSum(self, nums: List[int]) -> int:
        nums.sort(key=lambda num: abs(num))
        half = len(nums) // 2
        score = 0
        for i in range(half):
            score -= nums[i] * nums[i]
        for i in range(half, len(nums)):
            score += nums[i] * nums[i]
        return score
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem209(Problem):
    def test(self) -> bool:
        target = 7
        nums = [2, 3, 1, 2, 4, 3]

        expected = 2

        result = self.minSubArrayLen(target, nums)

        print(expected)

        return result == expected

    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        n = len(nums)
        r = 0
        sum = 0
        result = sys.maxsize
        for i in range(n):
            while r < n and sum < target:
                sum += nums[r]
                r += 1
            if r >= n and sum < target:
                break
            result = min(result, r - i)
            sum -= nums[i]

        return  result if result != sys.maxsize else 0
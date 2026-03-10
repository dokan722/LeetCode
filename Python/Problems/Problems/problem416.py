import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem416(Problem):
    def test(self) -> bool:
        nums = [1, 5, 11, 5]

        expected = True

        result = self.canPartition(nums)

        return expected == result

    def canPartition(self, nums: List[int]) -> bool:
        s = sum(nums)

        if s % 2 == 1:
            return False
        req = s // 2
        dp = [False] * (req + 1)
        dp[0] = True
        for num in nums:
            for i in range(req, num - 1, -1):
                dp[i] = dp[i] or dp[i - num]
            if dp[req]:
                return True

        return False
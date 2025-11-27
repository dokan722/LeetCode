import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3381(Problem):
    def test(self) -> bool:
        nums = [-5, 1, 2, -3, 4]
        k = 2

        expected = 4

        result = self.maxSubarraySum(nums, k)

        print(result)

        return result == expected

    def maxSubarraySum(self, nums: List[int], k: int) -> int:
        n = len(nums)
        worstPrefs = [sys.maxsize / 2] * k
        prefSum = 0
        maxSum = -sys.maxsize
        worstPrefs[k - 1] = 0
        for i in range(n):
            prefSum += nums[i]
            maxSum = max(maxSum, prefSum - worstPrefs[i % k])
            worstPrefs[i % k] = min(worstPrefs[i % k], prefSum)

        return maxSum
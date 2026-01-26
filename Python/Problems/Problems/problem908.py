import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem908(Problem):
    def test(self) -> bool:
        nums = [1, 3, 6]
        k = 3

        expected = 0

        result = self.smallestRangeI(nums, k)

        print(result)

        return result == expected

    def smallestRangeI(self, nums: List[int], k: int) -> int:
        maxValue = nums[0]
        minValue = nums[0]
        for i in range(1, len(nums)):
            maxValue = max(maxValue, nums[i])
            minValue = min(minValue, nums[i])
        return max(0, maxValue - minValue - 2 * k)
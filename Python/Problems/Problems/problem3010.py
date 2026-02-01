import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3010(Problem):
    def test(self) -> bool:
        nums = [10, 3, 1, 1]

        expected = 12

        result = self.minimumCost(nums)

        print(result)

        return result == expected

    def minimumCost(self, nums: List[int]) -> int:
        n = len(nums)
        m = min(nums[1], nums[2])
        sm = max(nums[1], nums[2])
        for i in range(3, n):
            if nums[i] < m:
                sm = m
                m = nums[i]
            elif nums[i] < sm:
                sm = nums[i]

        return nums[0] + m + sm
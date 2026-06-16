import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2971(Problem):
    def test(self) -> bool:
        nums = [5, 5, 5]

        expected = 15

        result = self.largestPerimeter(nums)

        print(result)

        return result == expected

    def largestPerimeter(self, nums: List[int]) -> int:
        n = len(nums)
        nums.sort()
        result = -1
        pref = nums[0] + nums[1]
        for i in range(2, n):
            if nums[i] < pref:
                result = nums[i] + pref
            pref += nums[i]
        return result
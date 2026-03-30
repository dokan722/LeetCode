import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3732(Problem):
    def test(self) -> bool:
        nums = [-5, 7, 0]

        expected = 3500000

        result = self.maxProduct(nums)

        print(result)

        return result == expected

    def maxProduct(self, nums: List[int]) -> int:
        n = len(nums)
        mins = [sys.maxsize, sys.maxsize]
        maxs = [-sys.maxsize, -sys.maxsize]
        for i in range(n):
            if nums[i] > maxs[0]:
                maxs[1] = maxs[0]
                maxs[0] = nums[i]
            elif nums[i] > maxs[1]:
                maxs[1] = nums[i]
            if nums[i] < mins[0]:
                mins[1] = mins[0]
                mins[0] = nums[i]
            elif nums[i] < mins[1]:
                mins[1] = nums[i]
        best = max(max(abs(mins[0] * mins[1]), abs(maxs[0] * maxs[1])), abs(maxs[0] * mins[0]))

        return best * 100000
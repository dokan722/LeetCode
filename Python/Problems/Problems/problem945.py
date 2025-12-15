import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem945(Problem):
    def test(self) -> bool:
        nums = [3, 2, 1, 2, 1, 7]

        expected = 6

        result = self.minIncrementForUnique(nums)

        print(result)

        return result == expected

    def minIncrementForUnique(self, nums: List[int]) -> int:
        n = len(nums)
        nums.sort()
        curr = -1
        result = 0
        for i in range(n):
            if nums[i] > curr:
                curr = nums[i]
            else:
                curr += 1
                result += curr - nums[i]

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3862(Problem):
    def test(self) -> bool:
        nums = [2, 1, 2]

        expected = 1

        result = self.smallestBalancedIndex(nums)

        print(result)

        return result == expected

    def smallestBalancedIndex(self, nums: list[int]) -> int:
        s = sum(nums)

        prod = 1
        i = len(nums) - 1
        while prod < s:
            s -= nums[i]
            if s == prod:
                return i
            if prod > s / nums[i]:
                break
            prod *= nums[i]
            i -= 1

        return -1
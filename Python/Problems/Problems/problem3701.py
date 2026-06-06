import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3701(Problem):
    def test(self) -> bool:
        nums = [1, 3, 5, 7]

        expected = -4

        result = self.alternatingSum(nums)

        print(result)

        return result == expected

    def alternatingSum(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(n):
            if i % 2 == 0:
                result += nums[i]
            else:
                result -= nums[i]

        return result
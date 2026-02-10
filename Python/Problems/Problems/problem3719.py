import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3719(Problem):
    def test(self) -> bool:
        nums = [3, 2, 2, 5, 4]

        expected = 5

        result = self.longestBalanced(nums)

        print(result)

        return result == expected

    def longestBalanced(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(n):
            even = set()
            odd = set()
            for j in range(i ,n):
                if nums[j] % 2 == 0:
                    even.add(nums[j])
                else:
                    odd.add(nums[j])
                if len(even) == len(odd):
                    result = max(result, j - i + 1)

        return result
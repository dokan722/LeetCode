import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2357(Problem):
    def test(self) -> bool:
        nums = [1, 5, 0, 3, 5]

        expected = 3

        result = self.minimumOperations(nums)

        print(result)

        return result == expected

    def minimumOperations(self, nums: List[int]) -> int:
        n = len(nums)
        present = [False] * 101
        result = 0
        for i in range(n):
            if not present[nums[i]]:
                present[nums[i]] = True
                result += 1
        if present[0]:
            result  -= 1
        return result
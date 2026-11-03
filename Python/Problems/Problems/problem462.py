import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem462(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3]

        expected = 2

        result = self.minMoves2(nums)

        print(result)

        return result == expected

    def minMoves2(self, nums: list[int]) -> int:
        n = len(nums)
        nums.sort()
        med = nums[n // 2]
        result = sum([abs(num - med) for num in nums])
        return result
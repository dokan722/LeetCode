import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3689(Problem):
    def test(self) -> bool:
        nums = [1, 3, 2]
        k = 2

        expected = 4

        result = self.maxTotalValue(nums, k)

        print(result)

        return result == expected

    def maxTotalValue(self, nums: List[int], k: int) -> int:
        return (max(nums) - min(nums)) * k
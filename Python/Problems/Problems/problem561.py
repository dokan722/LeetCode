import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem561(Problem):
    def test(self) -> bool:
        nums = [1, 4, 3, 2]

        expected = 4

        result = self.arrayPairSum(nums)

        print(result)

        return expected == result

    def arrayPairSum(self, nums: List[int]) -> int:
        n = len(nums)
        nums.sort()
        result = 0
        for i in range(0, n, 2):
            result += nums[i]
        return result
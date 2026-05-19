import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2790(Problem):
    def test(self) -> bool:
        nums = [2, 3, 7, 9, 3]

        expected = 21

        result = self.maxArrayValue(nums)

        print(result)

        return result == expected

    def maxArrayValue(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(n - 1, -1, -1):
            if result >= nums[i]:
                result += nums[i]
            else:
                result = nums[i]

        return result
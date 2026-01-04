import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1911(Problem):
    def test(self) -> bool:
        nums = [6, 2, 1, 2, 4, 5]

        expected = 10

        result = self.maxAlternatingSum(nums)

        print(result)

        return result == expected

    def maxAlternatingSum(self, nums: List[int]) -> int:
        n = len(nums)
        even = 0
        odd = nums[0]
        for i in range(1, n):
            even = max(even, odd - nums[i])
            odd = max(odd, even + nums[i])


        return max(even, odd)
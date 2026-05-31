import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2786(Problem):
    def test(self) -> bool:
        nums = [2, 3, 6, 1, 9, 2]
        x = 5

        expected = 13

        result = self.maxScore(nums, x)

        print(result)

        return result == expected

    def maxScore(self, nums: List[int], x: int) -> int:
        n = len(nums)
        even = nums[0] if nums[0] % 2 == 0 else -x
        odd = nums[0] if  nums[0] % 2 == 1 else -x
        for i in range(1, n):
            if nums[i] % 2 == 0:
                even = max(odd + nums[i] - x, even + nums[i])
            else:
                odd = max(even + nums[i] - x, odd + nums[i])

        return max(even, odd)
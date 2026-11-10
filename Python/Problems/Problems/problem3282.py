import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3282(Problem):
    def test(self) -> bool:
        nums = [1, 3, 1, 5]

        expected = 7

        result = self.findMaximumScore(nums)

        print(result)

        return result == expected

    def findMaximumScore(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        cur = 0
        for i in range(1, n):
            if nums[i] > nums[cur]:
                result += nums[cur] * (i - cur)
                cur = i
        result += nums[cur] * (n - 1 - cur)

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3788(Problem):
    def test(self) -> bool:
        nums = [10, -1, 3, -4, -5]

        expected = 17

        result = self.maximumScore(nums)

        print(result)

        return result == expected

    def maximumScore(self, nums: List[int]) -> int:
        n = len(nums)
        s = sum(nums)

        result = -sys.maxsize
        m = sys.maxsize
        for i in range(n - 1, 0, -1):
            m = min(m, nums[i])
            s -= nums[i]
            result = max(result, s - m)

        return result
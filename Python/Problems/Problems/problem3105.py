import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3105(Problem):
    def test(self) -> bool:
        nums = [1, 4, 3, 3, 2]

        expected = 2

        result = self.longestMonotonicSubarray(nums)

        print(result)

        return result == expected

    def longestMonotonicSubarray(self, nums: List[int]) -> int:
        n = len(nums)
        result = 1
        cur = 1
        inc = True
        for i in range(1, n):
            if inc and nums[i] > nums[i - 1]:
                cur += 1
            elif not inc and nums[i] < nums[i - 1]:
                cur += 1
            else:
                result = max(result, cur)
                inc = not inc
                cur = 1 + (1 if nums[i] != nums[i - 1] else 0)
        result = max(result, cur)

        return result
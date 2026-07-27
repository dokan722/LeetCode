import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2256(Problem):
    def test(self) -> bool:
        nums = [2, 5, 3, 9, 5, 3]

        expected = 3

        result = self.minimumAverageDifference(nums)

        print(result)

        return result == expected

    def minimumAverageDifference(self, nums: List[int]) -> int:
        n = len(nums)
        s = sum(nums)

        cur = 0
        best = sys.maxsize
        result = 0
        for i in range(n - 1):
            cur += nums[i]
            pre = cur // (i + 1)
            suf = (s - cur) // (n - i - 1)
            val = abs(pre - suf)
            if val < best:
                best = val
                result = i
        if s // n < best:
            result = n - 1

        return result
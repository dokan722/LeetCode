import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1658(Problem):
    def test(self) -> bool:
        nums = [1, 1, 4, 2, 3]
        x = 5

        expceted = 2

        result = self.minOperations(nums, x)

        print(result)

        return result == expceted

    def minOperations(self, nums: list[int], x: int) -> int:
        n = len(nums)
        total = sum(nums)

        if total < x:
            return -1
        if total == x:
            return n
        result = sys.maxsize
        r = 0
        cur = 0
        req = total - x
        for i in range(n):
            while r < n and cur < req:
                cur += nums[r]
                r += 1
            if cur == req:
                result = min(result, n - (r - i))
            if cur < req:
                break
            cur -= nums[i]

        return -1 if result == sys.maxsize else result
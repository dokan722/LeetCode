import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2875(Problem):
    def test(self) -> bool:
        nums = [5, 5, 4, 1, 2, 2, 2, 3, 2, 4, 2, 5]
        target = 56

        expected = 16

        result = self.minSizeSubarray(nums, target)

        print(result)

        return result == expected

    def minSizeSubarray(self, nums: List[int], target: int) -> int:
        n = len(nums)
        s = sum(nums)
        extra = target // s
        extraElems = n * extra
        target -= extra * s
        r = 0
        result = sys.maxsize
        cs = 0
        for i in range(n):
            while r < 2 * n and cs < target:
                cs += nums[r % n]
                r += 1
            if cs == target:
                result = min(result, extraElems + (r - i))
            cs -= nums[i]
        return -1 if result == sys.maxsize else result
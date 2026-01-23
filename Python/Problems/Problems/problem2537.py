import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2537(Problem):
    def test(self) -> bool:
        nums = [3, 1, 4, 3, 2, 2, 4]
        k = 2

        expected = 4

        result = self.countGood(nums, k)

        print(result)

        return expected == result

    def countGood(self, nums: List[int], k: int) -> int:
        n = len(nums)
        counts = dict()
        l = 0
        r = -1
        p = 0
        result = 0
        while r < n - 1:
            while p < k and r < n - 1:
                r += 1
                if nums[r] not in counts:
                    counts[nums[r]] = 0
                p += counts[nums[r]]
                counts[nums[r]] += 1
            while p >= k:
                result += n - r
                counts[nums[l]] -= 1
                p -= counts[nums[l]]
                l += 1

        return result
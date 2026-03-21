import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3737(Problem):
    def test(self) -> bool:
        nums = [1, 2, 2, 3]
        target = 2

        expected = 5

        result = self.countMajoritySubarrays(nums, target)

        print(result)

        return result == expected

    def countMajoritySubarrays(self, nums: List[int], target: int) -> int:
        n = len(nums)
        counts = [0] * (2 * n + 2)
        pref = [0] * (2 * n + 2)
        cur = n + 1
        pref[cur] = 1
        counts[cur] = 1
        result = 0
        for i in range(n):
            cur += (1 if nums[i] == target else -1)
            counts[cur] += 1
            pref[cur] = pref[cur - 1] + counts[cur]
            result += pref[cur - 1]

        return result
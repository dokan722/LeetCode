import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2453(Problem):
    def test(self) -> bool:
        nums = [3, 7, 8, 1, 1, 5]
        space = 2

        expected = 1

        result = self.destroyTargets(nums, space)

        print(result)

        return result == expected

    def destroyTargets(self, nums: List[int], space: int) -> int:
        maxTargets = 0
        result = 0
        counts = dict()
        for num in nums:
            rem = num % space
            if rem in counts:
                cur = counts[rem]
                counts[rem] = (min(cur[0], num), cur[1] + 1)
            else:
                counts[rem] = (num, 1)
            cand = counts[rem]
            if cand[1] > maxTargets or (cand[1] == maxTargets and result > cand[0]):
                maxTargets = cand[1]
                result = cand[0]

        return result
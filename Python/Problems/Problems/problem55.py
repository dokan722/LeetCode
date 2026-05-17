import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem55(Problem):
    def test(self) -> bool:
        nums = [2, 3, 1, 1, 4]

        expected = True

        result = self.canJump(nums)

        return result == expected

    def canJump(self, nums: List[int]) -> bool:
        n = len(nums)
        mx = 0
        for i in range(n):
            if mx < i:
                return False
            mx = max(mx, i + nums[i])

        return True
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem45(Problem):
    def test(self) -> bool:
        nums = [2, 3, 1, 1, 4]

        expected = 2

        result = self.jump(nums)

        print(result)

        return result == expected

    def jump(self, nums: List[int]) -> int:
        n = len(nums)
        maxReachable = 0
        curPos = 0
        jumps = 0
        for i in range(n):
            if i > curPos:
                jumps += 1
                curPos = maxReachable
            maxReachable = max(maxReachable, i + nums[i])

        return jumps
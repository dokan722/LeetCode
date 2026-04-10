import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3740(Problem):
    def test(self) -> bool:
        nums = [1, 2, 1, 1, 3]

        expected = 6

        result = self.minimumDistance(nums)

        print(result)

        return result == expected

    def minimumDistance(self, nums: List[int]) -> int:
        n = len(nums)
        prevs = [[-1, -1] for _ in range(n + 1)]
        result = sys.maxsize
        for i in range(n):
            if prevs[nums[i]][0] != -1 and prevs[nums[i]][1] != -1:
                result = min(result, prevs[nums[i]][1] - prevs[nums[i]][0] + i - prevs[nums[i]][1] + i - prevs[nums[i]][0])
            prevs[nums[i]][0] = prevs[nums[i]][1]
            prevs[nums[i]][1] = i

        return -1 if result == sys.maxsize else result
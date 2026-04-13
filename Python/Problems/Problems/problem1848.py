import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1848(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4, 5]
        target = 5
        start = 3

        expected = 1

        result = self.getMinDistance(nums, target, start)

        print(result)

        return result == expected

    def getMinDistance(self, nums: List[int], target: int, start: int) -> int:
        n = len(nums)
        result = sys.maxsize
        for i in range(n):
            if nums[i] == target:
                result = min(result, abs(i - start))

        return result
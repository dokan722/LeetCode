import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1546(Problem):
    def test(self) -> bool:
        nums = [1, 1, 1, 1, 1]
        target = 2

        expected = 2

        result = self.maxNonOverlapping(nums, target)

        print(result)

        return result == expected

    def maxNonOverlapping(self, nums: List[int], target: int) -> int:
        present = set()
        present.add(0)
        cur = 0
        result = 0
        for num in nums:
            cur += num
            req = cur - target
            if req in present:
                result += 1
                present.clear()
                cur = 0
            present.add(cur)

        return result
import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem523(Problem):
    def test(self) -> bool:
        nums = [23, 2, 4, 6, 7]
        k = 6

        expected = True

        result = self.checkSubarraySum(nums, k)

        print(result)

        return result == expected

    def checkSubarraySum(self, nums: List[int], k: int) -> bool:
        n = len(nums)
        if n > 2 * k:
            return True
        cur = nums[0]
        last = set()
        last.add(0)
        for i in range(1, n):
            next = cur + nums[i]
            req = next % k
            if req in last:
                return True
            last.add(cur % k)
            cur = next

        return False
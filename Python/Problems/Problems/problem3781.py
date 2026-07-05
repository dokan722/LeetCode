import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3781(Problem):
    def test(self) -> bool:
        nums = [2, 1, 5, 2, 3]
        s = "01010"

        expected = 7

        result = self.maximumScore(nums, s)

        print(result)

        return result == expected

    def maximumScore(self, nums: List[int], s: str) -> int:
        n = len(nums)
        queue = []
        result = 0
        for i in range(n):
            heapq.heappush(queue, -nums[i])
            if s[i] == '1':
                result -= heapq.heappop(queue)
        return result
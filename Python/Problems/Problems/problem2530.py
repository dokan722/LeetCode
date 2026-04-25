import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2530(Problem):
    def test(self) -> bool:
        nums = [10, 10, 10, 10, 10]
        k = 5

        expected = 50

        result = self.maxKelements(nums, k)

        print(result)

        return result == expected

    def maxKelements(self, nums: List[int], k: int) -> int:
        queue = []
        for num in nums:
            heapq.heappush(queue, -num)

        result = 0
        for i in range(k):
            top = -heapq.heappop(queue)
            result += top
            next = (top + 2) // 3
            heapq.heappush(queue, -next)

        return result
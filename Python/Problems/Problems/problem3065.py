import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3065(Problem):
    def test(self) -> bool:
        nums = [2, 11, 10, 1, 3]
        k = 10

        expected = 3

        result = self.minOperations(nums, k)

        print(result)

        return result == expected

    def minOperations(self, nums: List[int], k: int) -> int:
        result = 0
        for n in nums:
            if n < k:
                result += 1

        return result
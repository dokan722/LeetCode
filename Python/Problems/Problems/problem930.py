import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem930(Problem):
    def test(self) -> bool:
        nums = [1, 0, 1, 0, 1]
        goal = 2

        expected = 4

        result = self.numSubarraysWithSum(nums, goal)

        print(result)

        return result == expected

    def numSubarraysWithSum(self, nums: List[int], goal: int) -> int:
        counts = dict()
        cur = 0
        result = 0
        for num in nums:
            if cur in counts:
                counts[cur] += 1
            else:
                counts[cur] = 1
            cur += num
            req = cur - goal
            if req in counts:
                result += counts[req]

        return result
import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2317(Problem):
    def test(self) -> bool:
        nums = [3, 2, 4, 6]

        expected = 7

        result = self.maximumXOR(nums)

        print(result)

        return result == expected

    def maximumXOR(self, nums: List[int]) -> int:
        result = 0
        for n in nums:
            result |= n

        return result
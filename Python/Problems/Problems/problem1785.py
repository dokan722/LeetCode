import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1785(Problem):
    def test(self) -> bool:
        nums = [1, -1, 1]
        limit = 3
        goal = -4

        expected = 2

        result = self.minElements(nums, limit, goal)

        print(result)

        return result == expected

    def minElements(self, nums: List[int], limit: int, goal: int) -> int:
        s = sum(nums)

        return (abs(goal - s) + abs(limit) - 1) // limit
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2592(Problem):
    def test(self) -> bool:
        nums = [1, 3, 5, 2, 1, 3, 1]

        expected = 4

        result = self.maximizeGreatness(nums)

        print(result)

        return result == expected

    def maximizeGreatness(self, nums: List[int]) -> int:
        n = len(nums)
        if n < 2:
            return 0
        nums.sort()
        greatness = 0
        start = 0
        for i in range(1, n):
            if nums[i] != nums[i - 1]:
                l = i - start
                greatness = min(greatness + l, start)
                start = i

        fl = n - start
        greatness = min(greatness + fl, start)

        return greatness
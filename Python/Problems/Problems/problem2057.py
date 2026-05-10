import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2057(Problem):
    def test(self) -> bool:
        nums = [0, 1, 2]

        expected = 0

        result = self.smallestEqual(nums)

        print(result)

        return result == expected

    def smallestEqual(self, nums: List[int]) -> int:
        n = len(nums)
        for i in range(n):
            if i % 10 == nums[i]:
                return i

        return -1
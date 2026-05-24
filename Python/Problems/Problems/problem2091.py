import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2091(Problem):
    def test(self) -> bool:
        nums = [2, 10, 7, 5, 4, 1, 8, 6]

        expected = 5

        result = self.minimumDeletions(nums)

        print(result)

        return result == expected

    def minimumDeletions(self, nums: List[int]) -> int:
        n = len(nums)
        maxId = 0
        minId = 0
        for i in range(1, n):
            if nums[i] > nums[maxId]:
                maxId = i
            elif nums[i] < nums[minId]:
                minId = i
        first = min(maxId, minId)
        second = max(maxId, minId)
        return min(second + 1, min(n - first, first + 1 + (n - second)))
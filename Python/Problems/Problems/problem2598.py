import heapq
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2598(Problem):
    def test(self) -> bool:
        nums = [1, -10, 7, 13, 6, 8]
        value = 5

        expected = 4

        result = self.findSmallestInteger(nums, value)

        print(result)

        return result == expected

    def findSmallestInteger(self, nums: List[int], value: int) -> int:
        n = len(nums)
        counts = [0] * value

        for i in range(n):
            counts[(nums[i] % value + value) % value] += 1

        minCount = sys.maxsize
        minValue = sys.maxsize
        for i in range(value):
            if counts[i] < minCount:
                minCount = counts[i]
                minValue = i

        return value * minCount + minValue
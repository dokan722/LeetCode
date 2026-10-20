import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2089(Problem):
    def test(self) -> bool:
        nums = [1, 2, 5, 2, 3]
        target = 2

        expected = [1, 2]

        result = self.targetIndices(nums, target)

        print1DArray(result)

        return expected == result

    def targetIndices(self, nums: list[int], target: int) -> list[int]:
        n = len(nums)
        bigger = 0
        smaller = 0
        for num in nums:
            if num > target:
                bigger += 1
            elif num < target:
                smaller += 1
        targeted = n - bigger - smaller
        result = []
        for i in range(targeted):
            result.append(smaller + i)

        return result
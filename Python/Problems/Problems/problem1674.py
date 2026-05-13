import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1674(Problem):
    def test(self) -> bool:
        nums = [1, 2, 4, 3]
        limit = 4

        expected = 1

        result = self.minMoves(nums, limit)

        print(result)

        return result == expected

    def minMoves(self, nums: List[int], limit: int) -> int:
        counts = [0] * (2 * limit + 1)
        ranges = [0] *(2 * limit + 2)
        n = len(nums)
        l = n // 2
        for i in range(l):
            s = nums[i] + nums[n - 1 - i]
            left = min(nums[i] + 1, nums[n - 1 - i] + 1)
            right = max(limit + nums[i], limit + nums[n - 1 - i])
            counts[s] += 1
            ranges[left] += 1
            ranges[right + 1] -= 1
        result = sys.maxsize
        inRange = 0
        for i in range(2 * l + 1):
            inRange += ranges[i]
            mvs = l * 2 - inRange - counts[i]
            result = min(result, mvs)

        return result
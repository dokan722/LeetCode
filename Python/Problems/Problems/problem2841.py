import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2841(Problem):
    def test(self) -> bool:
        nums = [2, 6, 7, 3, 1, 7]
        m = 3
        k = 4

        expected = 18

        result = self.maxSum(nums, m, k)

        print(result)

        return result == expected

    def maxSum(self, nums: List[int], m: int, k: int) -> int:
        n = len(nums)
        counts = dict()
        cur = 0
        for i in range(k):
            if nums[i] not in counts:
                counts[nums[i]] = 1
            else:
                counts[nums[i]] += 1
            cur += nums[i]
        result = cur if len(counts) >= m else 0
        for i in range(k, n):
            cur += nums[i] - nums[i - k]
            if nums[i] not in counts:
                counts[nums[i]] = 1
            else:
                counts[nums[i]] += 1
            counts[nums[i - k]] -= 1
            if counts[nums[i - k]] == 0:
                counts.pop(nums[i - k])
            if len(counts) >= m:
                result = max(result, cur)

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2958(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 1, 2, 3, 1, 2]
        k = 2

        expected = 6

        result = self.maxSubarrayLength(nums, k)

        print(result)

        return result == expected

    def maxSubarrayLength(self, nums: List[int], k: int) -> int:
        n = len(nums)
        counts = dict()
        j = 0
        result = 0
        for i in range(n):
            if nums[i] in counts:
                counts[nums[i]] += 1
                if counts[nums[i]] > k:
                    result = max(result, i - j)
                    while counts[nums[i]] > k:
                        counts[nums[j]] -= 1
                        j += 1
            else:
                counts[nums[i]] = 1

        result = max(result, n - j)

        return result
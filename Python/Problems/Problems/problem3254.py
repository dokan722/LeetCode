import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3254(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4, 3, 2, 5]
        k = 3

        expected = [3, 4, -1, -1, -1]

        result = self.resultsArray(nums, k)

        print1DArray(result)

        return expected == result

    def resultsArray(self, nums: List[int], k: int) -> List[int]:
        n = len(nums)
        if k == 1:
            return nums
        result = [0] * (n - k + 1)
        cur = 1
        for i in range(1, n):
            if nums[i] == nums[i - 1] + 1:
                cur += 1
            else:
                cur = 1
            if i >= k - 1:
                if cur >= k:
                    result[i - k + 1] = nums[i]
                else:
                    result[i - k + 1] = -1

        return result
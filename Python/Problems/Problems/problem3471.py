import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3471(Problem):
    def test(self) -> bool:
        nums = [3, 9, 2, 1, 7]
        k = 3

        expected = 7

        result = self.largestInteger(nums, k)

        print(result)

        return result == expected

    def largestInteger(self, nums: List[int], k: int) -> int:
        n = len(nums)
        counts = [0] * 51
        for num in nums:
            counts[num] += 1

        if k == 1:
            for i in range(50, -1, -1):
                if counts[i] == 1:
                    return i
        elif k == n:
            for i in range(50, -1, -1):
                if counts[i] != 0:
                    return i
        else:
            for i in range(50, -1, -1):
                if counts[i] == 1 and (i == nums[0] or i == nums[n - 1]):
                    return i

        return -1
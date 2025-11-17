import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1437(Problem):
    def test(self) -> bool:
        nums = [1, 0, 0, 0, 1, 0, 0, 1]
        k = 2

        expected = True

        result = self.kLengthApart(nums, k)

        return result == expected

    def kLengthApart(self, nums: List[int], k: int) -> bool:
        n = len(nums)
        last = -1000000
        for i in range(n):
            if nums[i] == 1:
                if i - last - 1 < k:
                    return False
                last = i

        return True
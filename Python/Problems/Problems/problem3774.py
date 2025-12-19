import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3774(Problem):
    def test(self) -> bool:
        nums = [5, 2, 2, 4]
        k = 2

        expected = 5

        result = self.absDifference(nums, k)

        print(result)

        return expected == result

    def absDifference(self, nums: List[int], k: int) -> int:
        n = len(nums)
        result = 0
        nums.sort()
        for i in range(k):
            result -= nums[i]
            result += nums[n - i - 1]

        return result
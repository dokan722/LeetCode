import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2012(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3]

        expected = 2

        result = self.sumOfBeauties(nums)

        print(result)

        return result == expected

    def sumOfBeauties(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        mx = nums[0]
        mins = [0] * n
        mins[n - 1] = nums[n - 1]
        for i in range(n - 2, -1, -1):
            mins[i] = min(mins[i + 1], nums[i])
        for i in range(1, n - 1):
            if nums[i] > mx and nums[i] < mins[i + 1]:
                result += 2
            elif nums[i] > nums[i - 1] and nums[i] < nums[i + 1]:
                result += 1
            mx = max(mx, nums[i])
        return result
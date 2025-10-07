import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1800(Problem):
    def test(self) -> bool:
        nums = [12, 17, 15, 13, 10, 11, 12]

        expected = 33

        result = self.maxAscendingSum(nums)

        print(result)

        return expected == result

    def maxAscendingSum(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        runningSum = nums[0]
        for i in range(1, n):
            if nums[i] <= nums[i - 1]:
                result = max(result, runningSum)
                runningSum = nums[i]
            else:
                runningSum += nums[i]
        result = max(result, runningSum)

        return result
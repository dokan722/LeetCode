import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1749(Problem):
    def test(self) -> bool:
        nums = [2, -5, 1, -4, 3, -2]

        expected = 8

        result = self.maxAbsoluteSum(nums)

        print(result)

        return result == expected

    def maxAbsoluteSum(self, nums: List[int]) -> int:
        n = len(nums)
        maxPos = 0
        maxNeg = 0
        sumPos = 0
        sumNeg = 0
        for i in range(n):
            sumPos += nums[i]
            sumNeg += nums[i]
            sumNeg = min(0, sumNeg)
            sumPos = max(0, sumPos)
            maxPos = max(sumPos, maxPos)
            maxNeg = min(sumNeg, maxNeg)

        return max(maxPos, abs(maxNeg))
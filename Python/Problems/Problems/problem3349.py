import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3349(Problem):
    def test(self) -> bool:
        nums = [2, 5, 7, 8, 9, 2, 3, 4, 3, 1]
        k = 3

        expected = True

        result = self.hasIncreasingSubarrays(nums, k)

        return expected == result

    def hasIncreasingSubarrays(self, nums: List[int], k: int) -> bool:
        if k == 1:
            return True
        n = len(nums)
        firstFound = False
        l = 1
        for i in range(1, n):
            if nums[i] <= nums[i - 1]:
                if l < k:
                    firstFound = False
                l = 0
            l += 1
            if l % k == 0:
                if firstFound:
                    return True
                firstFound = True

        return False
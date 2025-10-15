import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3350(Problem):
    def test(self) -> bool:
        nums = [2, 5, 7, 8, 9, 2, 3, 4, 3, 1]

        expected = 3

        result = self.maxIncreasingSubarrays(nums)

        print(result)

        return expected == result

    def maxIncreasingSubarrays(self, nums: List[int]) -> int:
        n = len(nums)
        l = 1
        prev = 0
        result = 0
        for i in range(1, n):
            if nums[i - 1] >= nums[i]:
                result = max(result, l // 2)
                prev = l
                l = 0
            l += 1
            result = max(result, min(l, prev))
        result = max(result, l // 2)

        return result
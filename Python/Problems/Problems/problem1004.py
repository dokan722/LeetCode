import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1004(Problem):
    def test(self) -> bool:
        nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0]
        k = 2

        expected = 6

        result = self.longestOnes(nums, k)

        print(result)

        return expected == result

    def longestOnes(self, nums: List[int], k: int) -> int:
        n = len(nums)
        left = 0
        zeros = 0
        result = 0
        for i in range(n):
            if nums[i] == 0:
                zeros += 1
            while zeros > k and left <= i:
                if nums[left] == 0:
                    zeros -= 1
                left += 1
            result = max(result, i - left + 1)

        return result
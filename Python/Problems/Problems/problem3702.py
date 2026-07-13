import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3702(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3]

        expected = 2

        result = self.longestSubsequence(nums)

        print(result)

        return result == expected

    def longestSubsequence(self, nums: List[int]) -> int:
        n = len(nums)
        xor = 0
        nonZero = False
        for num in nums:
            xor ^= num
            if num != 0:
                nonZero = True
        if xor != 0:
            return n
        if nonZero:
            return n - 1
        return 0
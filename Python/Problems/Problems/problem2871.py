import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2871(Problem):
    def test(self) -> bool:
        nums = [1, 0, 2, 0, 1, 2]

        expected = 3

        result = self.maxSubarrays(nums)

        print(result)

        return result == expected

    def maxSubarrays(self, nums: List[int]) -> int:
        result = 0
        mask = -1
        cur = mask
        for num in nums:
            cur &= num
            if cur == 0:
                result += 1
                cur = mask

        if result == 0:
            return 1
        return result
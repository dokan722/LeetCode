import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3736(Problem):
    def test(self) -> bool:
        nums = [2, 1, 3]

        expected = 3

        result = self.minMoves(nums)

        print(result)

        return result == expected

    def minMoves(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        mx = nums[0]
        for i in range(1, n):
            if nums[i] > mx:
                result += (nums[i] - mx) * i
                mx = nums[i]
            else:
                result += mx - nums[i]

        return result
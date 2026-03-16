import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1760(Problem):
    def test(self) -> bool:
        nums = [2, 4, 8, 2]
        maxOperations = 4

        expected = 2

        result = self.minimumSize(nums, maxOperations)

        print(result)

        return result == expected

    def minimumSize(self, nums: List[int], maxOperations: int) -> int:
        n = len(nums)
        left = 1
        right = max(nums)
        while left < right:
            mid = (left + right) // 2
            possible = True
            operationsLeft = maxOperations
            for i in range(n):
                needed = ((nums[i] + mid - 1) // mid) - 1
                operationsLeft -= needed
                if operationsLeft < 0:
                    possible = False
                    break
            if possible:
                right = mid
            else:
                left = mid + 1

        return left
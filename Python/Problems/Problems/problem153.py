import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem153(Problem):
    def test(self) -> bool:
        nums = [3, 4, 5, 1, 2]

        expected = 1

        result = self.findMin(nums)

        print(result)

        return result == expected

    def findMin(self, nums: List[int]) -> int:
        n = len(nums)
        if nums[0] < nums[n - 1]:
            return nums[0]
        left = 0
        right = n - 1
        while left < right:
            mid = (left + right + 1) // 2
            if nums[mid] < nums[right]:
                right = mid
            else:
                left = mid

        return nums[left]
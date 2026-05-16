import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem154(Problem):
    def test(self) -> bool:
        nums = [1, 3, 5]

        expected = 1

        result = self.findMin(nums)

        print(result)

        return result == expected

    def findMin(self, nums: List[int]) -> int:
        n = len(nums)
        if n == 1:
            return nums[0]
        if nums[0] < nums[n - 1]:
            return nums[0]
        l = 1
        r = n - 1
        while l < r and nums[l] == nums[r]:
            l += 1
        while l < r:
            mid = (l + r) // 2
            if nums[mid - 1] > nums[mid]:
                return nums[mid]
            if nums[mid] <= nums[r]:
                r = mid
            else:
                l = mid + 1

        return nums[l]
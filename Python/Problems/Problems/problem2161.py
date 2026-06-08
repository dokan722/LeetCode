import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2161(Problem):
    def test(self) -> bool:
        nums = [9, 12, 5, 10, 14, 3, 10]
        pivot = 10

        expected = [9, 5, 3, 10, 10, 12, 14]

        result = self.pivotArray(nums, pivot)

        print1DArray(result)

        return expected == result

    def pivotArray(self, nums: List[int], pivot: int) -> List[int]:
        n = len(nums)
        result = [0] * n
        lp = 0
        rp = n - 1
        for i in range(n):
            left = nums[i]
            right = nums[n - 1 - i]
            if left < pivot:
                result[lp] = left
                lp += 1
            if right > pivot:
                result[rp] = right
                rp -= 1
        for i in range(lp, rp + 1):
            result[i] = pivot

        return result
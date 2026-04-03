import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3724(Problem):
    def test(self) -> bool:
        nums1 = [2, 8]
        nums2 = [1, 7, 3]

        expected = 4

        result = self.minOperations(nums1, nums2)

        print(result)

        return result == expected

    def minOperations(self, nums1: List[int], nums2: List[int]) -> int:
        n = len(nums1)
        result = 0
        last = sys.maxsize
        for i in range(n):
            result += abs(nums1[i] - nums2[i])
            if min(nums1[i], nums2[i]) <= nums2[n] and nums2[n] <= max(nums1[i], nums2[i]):
                last = 0
            else:
                last = min(last, min(abs(nums1[i] - nums2[n]), abs(nums2[i] - nums2[n])))

        return result + last + 1
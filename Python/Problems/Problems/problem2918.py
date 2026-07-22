import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2918(Problem):
    def test(self) -> bool:
        nums1 = [3, 2, 0, 1, 0]
        nums2 = [6, 5, 0]

        expected = 12

        result = self.minSum(nums1, nums2)

        print(result)

        return result == expected

    def minSum(self, nums1: List[int], nums2: List[int]) -> int:
        z1 = nums1.count(1)
        z2 = nums2.count(0)
        s1 = sum(nums1) + z1
        s2 = sum(nums2) + z2
        if (s1 < s2 and z1 == 0) or (s1 > s2 and z2 == 0):
            return -1
        return max(s1, s2)
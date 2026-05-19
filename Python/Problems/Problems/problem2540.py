import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2540(Problem):
    def test(self) -> bool:
        nums1 = [1, 2, 3]
        nums2 = [2, 4]

        expected = 2

        result = self.getCommon(nums1, nums2)

        print(result)

        return result == expected

    def getCommon(self, nums1: List[int], nums2: List[int]) -> int:
        n1 = len(nums1)
        n2 = len(nums2)
        i1 = 0
        i2 = 0
        while i1 < n1 and i2 < n2:
            if nums1[i1] == nums2[i2]:
                return nums1[i1]
            if nums1[i1] < nums2[i2]:
                i1 += 1
            else:
                i2 += 1

        return -1
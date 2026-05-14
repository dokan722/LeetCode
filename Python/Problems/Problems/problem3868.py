import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3868(Problem):
    def test(self) -> bool:
        nums1 = [10, 20]
        nums2 = [20, 10]

        expected = 0

        result = self.minCost(nums1, nums2)

        print(result)

        return result == expected

    def minCost(self, nums1: list[int], nums2: list[int]) -> int:
        n = len(nums1)
        counts = dict()
        for i in range(n):
            if nums1[i] in counts:
                counts[nums1[i]] += 1
            else:
                counts[nums1[i]] = 1
            if nums2[i] in counts:
                counts[nums2[i]] -= 1
            else:
                counts[nums2[i]] = -1

        result = 0
        for count in counts.values():
            val = abs(count)
            if val % 2 != 0:
                return -1
            result += val // 2

        return result // 2
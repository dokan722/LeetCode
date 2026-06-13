import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter, deque

from .problem import Problem


class Problem2425(Problem):
    def test(self) -> bool:
        nums1 = [2, 1, 3]
        nums2 = [10, 2, 5, 0]

        expected = 13

        result = self.xorAllNums(nums1, nums2)

        print(result)

        return result == expected

    def xorAllNums(self, nums1: List[int], nums2: List[int]) -> int:
        result = 0
        n = len(nums1)
        m = len(nums2)
        if n % 2 == 1:
            for num in nums2:
                result ^= num
        if m % 2 == 1:
            for num in nums1:
                result ^= num

        return result
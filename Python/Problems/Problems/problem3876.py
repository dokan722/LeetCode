import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3876(Problem):
    def test(self) -> bool:
        nums1 = [1, 4, 7]

        expected = True

        result = self.uniformArray(nums1)

        return result == expected

    def uniformArray(self, nums1: list[int]) -> bool:
        mn = nums1[0]
        odd = False
        for n in nums1:
            mn = min(mn, n)
            if n % 2 == 1:
                odd = True
        if mn % 2 == 1:
            return True
        return not  odd
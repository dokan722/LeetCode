import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3513(Problem):
    def test(self) -> bool:
        nums = [1, 2]

        expected = 2

        result = self.uniqueXorTriplets(nums)

        print(result)

        return result == expected

    def uniqueXorTriplets(self, nums: List[int]) -> int:
        n = len(nums)
        if n <= 2:
            return n
        num = 1
        while num <= n:
            num <<= 1
        return num
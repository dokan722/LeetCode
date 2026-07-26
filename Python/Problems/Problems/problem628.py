import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem628(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3]

        expected = 6

        result = self.maximumProduct(nums)

        print(result)

        return result == expected

    def maximumProduct(self, nums: List[int]) -> int:
        max1 = -sys.maxsize
        max2 = -sys.maxsize
        max3 = -sys.maxsize
        min1 = sys.maxsize
        min2 = sys.maxsize
        for n in nums:
            if n >= max1:
                max3 = max2
                max2 = max1
                max1 = n
            elif n >= max2:
                max3 = max2
                max2 = n
            elif n > max3:
                max3 = n

            if n <= min1:
                min2 = min1
                min1 = n
            elif n < min2:
                min2 = n
        return max(min1 * min2 * max1, max1 * max2 * max3)
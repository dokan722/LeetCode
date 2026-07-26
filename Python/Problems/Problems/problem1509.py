import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1509(Problem):
    def test(self) -> bool:
        nums = [5, 3, 2, 4]

        expected = 0

        result = self.minDifference(nums)

        print(result)

        return result == expected

    def minDifference(self, nums: List[int]) -> int:
        if len(nums) < 4:
            return 0

        max1 = -sys.maxsize
        max2 = -sys.maxsize
        max3 = -sys.maxsize
        max4 = -sys.maxsize
        min1 = sys.maxsize
        min2 = sys.maxsize
        min3 = sys.maxsize
        min4 = sys.maxsize
        for n in nums:
            if n >= max1:
                max4 = max3
                max3 = max2
                max2 = max1
                max1 = n
            elif n >= max2:
                max4 = max3
                max3 = max2
                max2 = n
            elif n >= max3:
                max4 = max3
                max3 = n
            elif n > max4:
                max4 = n

            if n <= min1:
                min4 = min3
                min3 = min2
                min2 = min1
                min1 = n
            elif n <= min2:
                min4 = min3
                min3 = min2
                min2 = n
            elif n <= min3:
                min4 = min3
                min3 = n
            elif n < min4:
                min4 = n

        return min(min(max1 - min4, max4 - min1), min(max2 - min3, max3 - min2))
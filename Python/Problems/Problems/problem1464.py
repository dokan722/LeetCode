import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1464(Problem):
    def test(self) -> bool:
        nums = [3, 4, 5, 2]

        expected = 12

        result = self.maxProduct(nums)

        print(result)

        return result == expected

    def maxProduct(self, nums: List[int]) -> int:
        max1 = -sys.maxsize
        max2 = -sys.maxsize
        for num in nums:
            if max1 <= num:
                max2 = max1
                max1 = num
            elif max2 <= num:
                max2 = num

        return (max1 - 1) * (max2 - 1)
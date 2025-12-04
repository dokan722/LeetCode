import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1913(Problem):
    def test(self) -> bool:
        nums = [4, 2, 5, 9, 7, 4, 8]

        expected = 64

        result = self.maxProductDifference(nums)

        print(result)

        return result == expected

    def maxProductDifference(self, nums: List[int]) -> int:
        n = len(nums)
        max1 = nums[0]
        max2 = -sys.maxsize
        min1 = nums[0]
        min2 = sys.maxsize
        for i in range(1, n):
            if nums[i] >= max2:
                if nums[i] >= max1:
                    max2 = max1
                    max1 = nums[i]
                else:
                    max2 = nums[i]

            if nums[i] <= min2:
                if nums[i] <= min1:
                    min2 = min1
                    min1 = nums[i]
                else:
                    min2 = nums[i]

        return (max1 * max2) - (min1 * min2)
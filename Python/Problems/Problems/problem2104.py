import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2104(Problem):
    def test(self) -> bool:
        nums = [4, -2, -3, 4, 1]

        expected = 59

        result = self.subArrayRanges(nums)

        print(result)

        return result == expected

    def subArrayRanges(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(n):
            currMin = nums[i]
            currMax = nums[i]
            for j in range(i + 1, n):
                currMin = min(currMin, nums[j])
                currMax = max(currMax, nums[j])
                result += currMax - currMin

        return result
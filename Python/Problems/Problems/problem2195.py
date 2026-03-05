import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2195(Problem):
    def test(self) -> bool:
        nums = [1, 4, 25, 10, 25]
        k = 2

        expected = 5

        result = self.minimalKSum(nums, k)

        print(result)

        return expected == result

    def minimalKSum(self, nums: List[int], k: int) -> int:
        n = len(nums)
        currSum = k * (k + 1) // 2
        nums.sort()
        th = k
        prev = -1
        for i in range(n):
            if nums[i] > th:
                break
            elif nums[i] != prev:
                th += 1
                currSum += th - nums[i]
                prev = nums[i]

        return currSum
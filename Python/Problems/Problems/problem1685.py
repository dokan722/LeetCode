import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1685(Problem):
    def test(self) -> bool:
        nums = [1, 4, 6, 8, 10]

        expected = [24, 15, 13, 15, 21]

        result = self.getSumAbsoluteDifferences(nums)

        print1DArray(result)

        return expected == result

    def getSumAbsoluteDifferences(self, nums: List[int]) -> List[int]:
        n = len(nums)
        result = []
        s = sum(nums)

        preSum = 0
        for i in range(n):
            sumAfter = s - preSum - (n - i) * nums[i]
            sumBefore = i * nums[i] - preSum
            result.append(sumAfter + sumBefore)
            preSum += nums[i]
        return result
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2574(Problem):
    def test(self) -> bool:
        nums = [10, 4, 8, 3]

        expected = [15, 1, 11, 22]

        result = self.leftRightDifference(nums)

        print1DArray(result)

        return result == expected

    def leftRightDifference(self, nums: List[int]) -> List[int]:
        n = len(nums)
        sum = 0
        for num in nums:
            sum += num
        result = [0] * n
        curr = 0
        for i in range(n):
            result[i] = abs(2 * curr - sum + nums[i])
            curr += nums[i]

        return result
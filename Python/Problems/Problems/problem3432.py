import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3432(Problem):
    def test(self) -> bool:
        nums = [10, 10, 3, 7, 6]

        expected = 4

        result = self.countPartitions(nums)

        print(result)

        return expected == result

    def countPartitions(self, nums: List[int]) -> int:
        n = len(nums)
        s = sum(nums)
        curr = 0
        result = 0
        for i in range(n - 1):
            curr += nums[i]
            if curr % 2 == (s - curr) % 2:
                result += 1

        return result
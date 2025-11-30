import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1590(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3]
        p = 7

        expected = -1

        result = self.minSubarray(nums, p)

        print(result)

        return result == expected

    def minSubarray(self, nums: List[int], p: int) -> int:
        n = len(nums)
        rest = sum(nums) % p
        if rest == 0:
            return 0

        prev = dict()
        prev[0] = -1
        result = sys.maxsize
        curr = 0
        for i in range(n):
            curr = (curr + nums[i]) % p
            req = (curr - rest + p) % p
            if req in prev:
                result = min(result, i - prev[req])
            prev[curr] = i

        return  -1 if result >= n else result
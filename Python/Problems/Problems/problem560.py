import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem560(Problem):
    def test(self) -> bool:
        nums = [1, 1, 1]
        k = 2

        expected = 2

        result = self.subarraySum(nums, k)

        print(result)

        return result == expected

    def subarraySum(self, nums: List[int], k: int) -> int:
        prev = dict()
        prev[0] = 1
        cur = 0
        result = 0
        for num in nums:
            cur += num
            req = cur - k
            if req in prev:
                result += prev[req]
            if cur in prev:
                prev[cur] += 1
            else:
                prev[cur] = 1

        return result
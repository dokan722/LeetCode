import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3397(Problem):
    def test(self) -> bool:
        nums = [1, 2, 2, 3, 3, 4]
        k = 2

        expected = 6

        result = self.maxDistinctElements(nums, k)

        print(result)

        return expected == result

    def maxDistinctElements(self, nums: List[int], k: int) -> int:
        nums.sort()
        prev = -sys.maxsize
        result = 0
        for num in nums:
            curr = min(max(num - k, prev + 1), num + k)
            if curr > prev:
                result += 1
                prev = curr

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2913(Problem):
    def test(self) -> bool:
        nums = [1, 2, 1]

        expected = 15

        result = self.sumCounts(nums)

        print(result)

        return result == expected

    def sumCounts(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(n):
            present = [False] * 101
            cur = 0
            for j in range(i, n):
                if not present[nums[j]]:
                    present[nums[j]] = True
                    cur += 1
                result += cur * cur

        return result
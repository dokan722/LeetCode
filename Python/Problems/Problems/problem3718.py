import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3718(Problem):
    def test(self) -> bool:
        nums = [8, 2, 3, 4, 6]
        k = 2

        expected = 10

        result = self.missingMultiple(nums, k)

        print(result)

        return result == expected

    def missingMultiple(self, nums: List[int], k: int) -> int:
        mx = (100 + k) // k
        present = [False] * mx
        for n in nums:
            if n % k == 0:
                present[n // k] = True

        for i in range(1, mx):
            if not present[i]:
                return i * k
        return mx * k
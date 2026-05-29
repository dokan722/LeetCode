import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3300(Problem):
    def test(self) -> bool:
        nums = [10, 12, 13, 14]

        expected = 1

        result = self.minElement(nums)

        print(result)

        return result == expected

    def minElement(self, nums: List[int]) -> int:
        result = sys.maxsize
        for num in nums:
            n = num
            d = 0
            while n > 0:
                d += n % 10
                n //= 10
            result = min(result, d)

        return result
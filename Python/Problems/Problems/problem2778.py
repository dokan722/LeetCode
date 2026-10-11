import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2778(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]

        expected = 21

        result = self.sumOfSquares(nums)

        print(result)

        return result == expected

    def sumOfSquares(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(1, n + 1):
            if n % i == 0:
                result += nums[i - 1] * nums[i - 1]

        return result
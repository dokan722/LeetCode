import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2553(Problem):
    def test(self) -> bool:
        nums = [13, 25, 83, 77]

        expected = [1, 3, 2, 5, 8, 3, 7, 7]

        result = self.separateDigits(nums)

        print1DArray(result)

        return expected == result

    def separateDigits(self, nums: List[int]) -> List[int]:
        n = len(nums)
        result = []
        for i in range(n - 1, -1, -1):
            num = nums[i]
            while num > 0:
                result.append(num % 10)
                num //= 10
        result.reverse()
        return result
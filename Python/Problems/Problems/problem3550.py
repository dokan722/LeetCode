import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3550(Problem):
    def test(self) -> bool:
        nums = [1, 3, 2]

        expected = 2

        result = self.smallestIndex(nums)

        print(result)

        return result == expected

    def smallestIndex(self, nums: List[int]) -> int:
        n = len(nums)
        for i in range(n):
            num = nums[i]
            s = 0
            while num > 0:
                s += num % 10
                num //= 10
                if s == i:
                    return s

        return -1
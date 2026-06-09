import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2568(Problem):
    def test(self) -> bool:
        nums = [2, 1]

        expected = 4

        result = self.minImpossibleOR(nums)

        print(result)

        return result == expected

    def minImpossibleOR(self, nums: List[int]) -> int:
        s = set()
        for num in nums:
            s.add(num)
        result = 1
        while result in s:
            result *= 2
        return result
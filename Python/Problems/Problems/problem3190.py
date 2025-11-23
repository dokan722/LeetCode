import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3190(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]

        expected = 3

        result = self.minimumOperations(nums)

        print(result)

        return result == expected

    def minimumOperations(self, nums: List[int]) -> int:
        result = 0
        for num in nums:
            if num % 3 != 0:
                result += 1
        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1887(Problem):
    def test(self) -> bool:
        nums = [1, 1, 2, 2, 3]

        expected = 4

        result = self.reductionOperations(nums)

        print(result)

        return result == expected

    def reductionOperations(self, nums: List[int]) -> int:
        n = len(nums)
        nums.sort()
        result = 0
        for i in range(n - 2, -1, -1):
            if nums[i] != nums[i + 1]:
                result += n - i - 1

        return result
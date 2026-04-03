import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3779(Problem):
    def test(self) -> bool:
        nums = [3, 8, 3, 6, 5, 8]

        expected = 1

        result = self.minOperations(nums)

        print(result)

        return result == expected

    def minOperations(self, nums: List[int]) -> int:
        n = len(nums)
        present = set()
        for i in range(n - 1, -1, -1):
            if nums[i] in present:
                return (i + 1 + 2) // 3
            present.add(nums[i])

        return 0
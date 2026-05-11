import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2216(Problem):
    def test(self) -> bool:
        nums = [1, 1, 2, 3, 5]

        expected = 1

        result = self.minDeletion(nums)

        print(result)

        return result == expected

    def minDeletion(self, nums: List[int]) -> int:
        n = len(nums)
        if n == 1:
            return 1
        result = 0
        i = 0
        j = 1
        while j < n:
            if nums[i] == nums[j]:
                result += 1
                j += 1
            else:
                i = j + 1
                j += 2
        if (n - result) % 2 != 0:
            result += 1
        return result
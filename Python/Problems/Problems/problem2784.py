import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2784(Problem):
    def test(self) -> bool:
        nums = [2, 1, 3]

        expected = False

        result = self.isGood(nums)

        print(result)

        return result == expected

    def isGood(self, nums: List[int]) -> bool:
        n = len(nums)
        present = [False] * 201
        count = 0
        for num in nums:
            if (present[num] and num != n - 1 or num > n - 1):
                return False
            present[num] = True
            if num != n - 1:
                count += 1


        return count == n - 2 and present[n - 1]
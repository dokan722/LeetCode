import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3659(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]
        k = 2

        expected = True

        result = self.partitionArray(nums, k)

        return result == expected

    def partitionArray(self, nums: List[int], k: int) -> bool:
        n = len(nums)
        if n % k != 0:
            return False
        groups = n // k
        counts = dict()
        for num in nums:
            if num in counts:
                counts[num] += 1
            else:
                counts[num] = 1
            if counts[num] > groups:
                return False

        return True
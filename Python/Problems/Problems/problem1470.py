import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1470(Problem):
    def test(self) -> bool:
        nums = [2, 5, 1, 3, 4, 7]
        n = 3

        expected = [2, 3, 5, 4, 1, 7]

        result = self.shuffle(nums, n)

        print1DArray(result)

        return expected == result

    def shuffle(self, nums: List[int], n: int) -> List[int]:
        result = [0] * (2 * n)
        for i in range(n):
            result[2 * i] = nums[i]
            result[2 * i + 1] = nums[n + i]

        return result
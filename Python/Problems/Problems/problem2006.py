import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2006(Problem):
    def test(self) -> bool:
        nums = [3, 2, 1, 5, 4]
        k = 2

        expected = 3

        result = self.countKDifference(nums, k)

        print(result)

        return expected == result

    def countKDifference(self, nums: List[int], k: int) -> int:
        n = len(nums)
        counts = [0] * (100 + 2 * k + 1)
        result = 0
        for i in range(n):
            result += counts[nums[i]] + counts[nums[i] + 2 * k]
            counts[nums[i] + k] += 1
        return result
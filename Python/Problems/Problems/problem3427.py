import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3427(Problem):
    def test(self) -> bool:
        nums = [2, 3, 1]

        expected = 11

        result = self.subarraySum(nums)

        print(result)

        return result == expected

    def subarraySum(self, nums: List[int]) -> int:
        n = len(nums)
        pref = [0]
        result = 0

        for i in range(n):
            pref.append(nums[i] + pref[i])
            start = max(0, i - nums[i])
            result += pref[i + 1] - pref[start]

        return result
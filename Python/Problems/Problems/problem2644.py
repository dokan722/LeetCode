import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2644(Problem):
    def test(self) -> bool:
        nums = [2, 9, 15, 50]
        divisors = [5, 3, 7, 2]

        expected = 2

        result = self.maxDivScore(nums, divisors)

        print(result)

        return result == expected

    def maxDivScore(self, nums: List[int], divisors: List[int]) -> int:
        n = len(nums)
        m = len(divisors)
        result = divisors[0]
        best = 0
        for i in range(m):
            cur = 0
            for j in range(n):
                if nums[j] % divisors[i] == 0:
                    cur += 1
            if cur > best or (cur == best and divisors[i] < result):
                best = cur
                result = divisors[i]

        return result
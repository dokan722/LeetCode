import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3867(Problem):
    def test(self) -> bool:
        nums = [2, 6, 4]

        expected = 2

        result = self.gcdSum(nums)

        print(result)

        return result == expected

    def gcdSum(self, nums: list[int]) -> int:
        n = len(nums)
        prefs = [0] * n
        mx = 0
        for i in range(n):
            mx = max(mx, nums[i])
            prefs[i] = self.gcd(mx, nums[i])
        prefs.sort()
        result = 0
        for i in range(n // 2):
            result += self.gcd(prefs[i], prefs[n - 1 - i])
        return result

    def gcd(self, a, b):
        if b > a:
            (a, b) = (b, a)
        while b != 0:
            a %= b
            (a, b) = (b, a)

        return a
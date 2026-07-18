import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1979(Problem):
    def test(self) -> bool:
        nums = [2, 5, 6, 9, 10]

        expected = 2

        result = self.findGCD(nums)

        print(result)

        return result == expected

    def findGCD(self, nums: List[int]) -> int:
        mx = 0
        mn = 1001
        for num in nums:
            mn = min(mn, num)
            mx = max(mx, num)

        while mn != 0:
            mx %= mn
            (mx, mn) = (mn, mx)

        return mx
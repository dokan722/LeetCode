import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3153(Problem):
    def test(self) -> bool:
        nums = [13, 23, 12]

        expected = 4

        result = self.sumDigitDifferences(nums)

        print(result)

        return result == expected

    def sumDigitDifferences(self, nums: List[int]) -> int:
        n = len(nums)
        l = len(str(nums[0]))
        digs = [[0 for _ in range(10)] for _ in range(l)]
        result = 0
        for i in range(n):
            num = nums[i]
            for j in range(l):
                c = num % 10
                diff = 0
                for k in range(10):
                    if k != c:
                        diff += digs[j][k]
                result += diff
                digs[j][c] += 1
                num //= 10

        return result
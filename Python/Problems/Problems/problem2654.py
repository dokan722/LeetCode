import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2654(Problem):
    def test(self) -> bool:
        nums = [2, 6, 3, 4]

        expected = 4

        result = self.minOperations(nums)

        print(result)

        return result == expected

    def minOperations(self, nums: List[int]) -> int:
        n = len(nums)
        ones = 0
        for i in range(n):
            if nums[i] == 1:
                ones += 1

        if ones > 0:
            return n - ones

        minDist = sys.maxsize
        for i in range(n):
            curr = nums[i]
            for j in range(i + 1, n):
                curr = self.gcd(curr, nums[j])
                if curr == 1:
                    minDist = min(j - i - 1, minDist)
                    break


        if minDist > n:
            return -1

        return n + minDist

    def gcd(self, a: int, b: int) -> int:
        while b != 0:
            temp = b
            b = a % b
            a = temp

        return a
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3761(Problem):
    def test(self) -> bool:
        nums = [12, 21, 45, 33, 54]

        expected = 1

        result = self.minMirrorPairDistance(nums)

        print(result)

        return result == expected

    def minMirrorPairDistance(self, nums: List[int]) -> int:
        n = len(nums)
        result = sys.maxsize
        last = dict()
        for i in range(n):
            num = nums[i]
            if num in last:
                result = min(result, i - last[num])

            rev = 0
            while num > 0:
                rev *= 10
                rev += num % 10
                num //= 10
            last[rev] = i

        return -1 if result == sys.maxsize else result
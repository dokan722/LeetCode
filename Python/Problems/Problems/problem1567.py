import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1567(Problem):
    def test(self) -> bool:
        nums = [1, -2, -3, 4]

        expected = 4

        result = self.getMaxLen(nums)

        print(result)

        return expected == result

    def getMaxLen(self, nums: List[int]) -> int:
        n = len(nums)
        prev = -1
        first = -1
        last = -1
        count = 0
        result = 0
        for i in range(n):
            if nums[i] < 0:
                count += 1
                last = i
                if first == -1:
                    first = i
            elif nums[i] == 0:
                if count % 2 == 0:
                    result = max(result, i - prev - 1)
                else:
                    best = max(i - first - 1, last - prev - 1)
                    result = max(result, best)
                count = 0
                first = -1
                last = -1
                prev = i
        if count % 2 == 0:
            result = max(result, n - prev - 1)
        else:
            best = max(n - first - 1, last - prev - 1)
            result = max(result, best)


        return result
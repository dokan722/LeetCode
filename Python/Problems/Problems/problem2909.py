import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2909(Problem):
    def test(self) -> bool:
        nums = [8, 6, 1, 5, 3]

        expected = 9

        result = self.minimumSum(nums)

        print(result)

        return result == expected

    def minimumSum(self, nums: List[int]) -> int:
        n = len(nums)
        rightMins = [0] * n
        rightMins[n - 1] = nums[n - 1]
        for i in range(n - 2, -1, -1):
            rightMins[i] = min(nums[i], rightMins[i + 1])
        curMin = nums[0]
        result = sys.maxsize
        for i in range(n - 1):
            if nums[i] > curMin and nums[i] > rightMins[i + 1]:
                result = min(result, curMin + nums[i] + rightMins[i + 1])
            curMin = min(curMin, nums[i])

        return -1 if result == sys.maxsize else result
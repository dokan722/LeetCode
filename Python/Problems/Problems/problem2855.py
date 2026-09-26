import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2855(Problem):
    def test(self) -> bool:
        nums = [3, 4, 5, 1, 2]

        expected = 2

        result = self.minimumRightShifts(nums)

        print(result)

        return result == expected

    def minimumRightShifts(self, nums: List[int]) -> int:
        n = len(nums)
        pos = n - 1 if nums[n - 1] >= nums[0] else -1
        for i in range(n - 1):
            if nums[i] > nums[i + 1]:
                if pos != -1:
                    return -1
                pos = i

        return n - pos - 1
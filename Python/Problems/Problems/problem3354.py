import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3354(Problem):
    def test(self) -> bool:
        nums = [1, 0, 2, 0, 3]

        expected = 2

        result = self.countValidSelections(nums)

        print(result)

        return expected == result

    def countValidSelections(self, nums: List[int]) -> int:
        n = len(nums)
        s = 0
        for num in nums:
            s += num

        result = 0
        curr = 0
        for i in range(n):
            curr += nums[i]
            if nums[i] == 0:
                diff = abs(2 * curr - s)
                result += 2 - min(diff, 2)

        return result
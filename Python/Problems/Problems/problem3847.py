import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3847(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3]

        expected = 0

        result = self.scoreDifference(nums)

        print(result)

        return result == expected

    def scoreDifference(self, nums: List[int]) -> int:
        n = len(nums)
        det = 1
        result = 0
        for i in range(n):
            if nums[i] % 2 == 1:
                det *= -1
            if i % 6 == 5:
                det *= -1
            result += nums[i] * det

        return result
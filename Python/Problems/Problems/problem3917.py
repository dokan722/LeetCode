import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3917(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]

        expected = [2, 1, 1, 0]

        result = self.countOppositeParity(nums)

        print1DArray(result)

        return expected == result

    def countOppositeParity(self, nums: list[int]) -> list[int]:
        n = len(nums)
        even = 0
        odd = 0
        result = [0] * n
        for i in range(n - 1, -1, -1):
            if nums[i] % 2 == 0:
                result[i] = odd
                even += 1
            else:
                result[i] = even
                odd += 1

        return result
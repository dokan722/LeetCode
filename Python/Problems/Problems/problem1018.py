import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1018(Problem):
    def test(self) -> bool:
        nums = [0, 1, 1]

        expected = [True, False, False]

        result = self.prefixesDivBy5(nums)

        print1DArray(result)

        return result == expected

    def prefixesDivBy5(self, nums: List[int]) -> List[bool]:
        n = len(nums)
        result = []
        curr = 0
        for i in range(n):
            curr = (2 * curr + nums[i]) % 10
            result.append(curr == 5 or curr == 0)

        return result
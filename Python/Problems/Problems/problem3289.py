import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3289(Problem):
    def test(self) -> bool:
        nums = [7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2]

        expected = [4, 5]

        result = self.getSneakyNumbers(nums)

        print1DArray(result)

        return expected == result

    def getSneakyNumbers(self, nums: List[int]) -> List[int]:
        n = len(nums)
        seen = [False] * n
        first = -1
        for num in nums:
            if seen[num]:
                if first != -1:
                    return [first, num]
                first = num
            else:
                seen[num] = True

        return []
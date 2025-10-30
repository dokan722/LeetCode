import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1512(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 1, 1, 3]

        expected = 4

        result = self.numIdenticalPairs(nums)

        print(result)

        return expected == result

    def numIdenticalPairs(self, nums: List[int]) -> int:
        counts = dict()
        result = 0
        for num in nums:
            if num in counts:
                result += counts[num]
                counts[num] += 1
            else:
                counts[num] = 1

        return result
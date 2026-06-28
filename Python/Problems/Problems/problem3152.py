import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3152(Problem):
    def test(self) -> bool:
        nums = [3, 4, 1, 2, 6]
        queries = [[0, 4]]

        expected = [False]

        result = self.isArraySpecial(nums, queries)

        print1DArray(result)

        return expected == result

    def isArraySpecial(self, nums: List[int], queries: List[List[int]]) -> List[bool]:
        n = len(nums)
        lastSame = [0]
        for i in range(1, n):
            if nums[i] % 2 == nums[i - 1] % 2:
                lastSame.append(i)
            else:
                lastSame.append(lastSame[i - 1])

        m = len(queries)
        result = []
        for i in range(m):
            if lastSame[queries[i][1]] <= queries[i][0]:
                result.append(True)
            else:
                result.append(False)

        return result
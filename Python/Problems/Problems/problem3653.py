import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3653(Problem):
    def test(self) -> bool:
        nums = [1, 1, 1]
        queries = [[0, 2, 1, 4]]

        expected = 4

        result = self.xorAfterQueries(nums, queries)

        print(result)

        return result == expected

    def xorAfterQueries(self, nums: List[int], queries: List[List[int]]) -> int:
        for query in queries:
            for i in range(query[0], query[1] + 1):
                x = nums[i] * query[3] % 1000000007
                nums[i] = x
        result = nums[0]
        for i in range(1, len(nums)):
            result ^= nums[i]

        return result
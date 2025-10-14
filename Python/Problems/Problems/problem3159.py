import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3159(Problem):
    def test(self) -> bool:
        nums = [1, 3, 1, 7]
        queries = [1, 3, 2, 4]
        x = 1

        expected = [0, -1, 2, -1]

        result = self.occurrencesOfElement(nums, queries, x)

        print1DArray(result)

        return expected == result

    def occurrencesOfElement(self, nums: List[int], queries: List[int], x: int) -> List[int]:
        n = len(nums)
        ids = []
        for i in range(n):
            if nums[i] == x:
                ids.append(i)

        m = len(queries)
        maxId = len(ids)
        if (maxId == 0):
            return [-1] * m
        result = [ids[queries[i] - 1] if queries[i] <= maxId else -1 for i in range(m)]


        return result
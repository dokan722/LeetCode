import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2593(Problem):
    def test(self) -> bool:
        nums = [2, 1, 3, 4, 5, 2]

        expected = 7

        result = self.findScore(nums)

        print(result)

        return result == expected

    def findScore(self, nums: List[int]) -> int:
        n = len(nums)
        queue = []
        marked = [False] * (n + 2)
        for i in range(n):
            heapq.heappush(queue, [nums[i], i])

        result = 0
        while queue:
            item = heapq.heappop(queue)
            id = item[1]
            if not marked[id + 1]:
                marked[id] = True
                marked[id + 1] = True
                marked[id + 2] = True
                result += item[0]

        return result
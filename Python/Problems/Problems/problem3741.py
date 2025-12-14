import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3741(Problem):
    def test(self) -> bool:
        nums = [1, 1, 2, 3, 2, 1, 2]

        expected = 8

        result = self.minimumDistance(nums)

        print(result)

        return expected == result

    def minimumDistance(self, nums: List[int]) -> int:
        n = len(nums)
        pairs = dict()
        result = sys.maxsize
        for i in range(n):
            if nums[i] not in pairs:
                pairs[nums[i]] = [i, i]
            else:
                pair = pairs[nums[i]]
                if pair[0] == pair[1]:
                    pairs[nums[i]] = [pair[0], i]
                else:
                    result = min(result, 2 * (i - pair[0]))
                    pairs[nums[i]] = [pair[1], i]

        return -1 if result == sys.maxsize else result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1679(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]
        k = 5

        expected = 2

        result = self.maxOperations(nums, k)

        print(result)

        return result == expected

    def maxOperations(self, nums: List[int], k: int) -> int:
        counts = dict()
        result = 0
        for num in nums:
            if num in counts:
                counts[num] += 1
            else:
                counts[num] = 1
            req = k - num
            if req != num:
                if (k - num) in counts and counts[k - num] >= counts[num]:
                    result += 1
            else:
                if counts[num] % 2 == 0:
                    result += 1

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2090(Problem):
    def test(self) -> bool:
        nums = [7, 4, 3, 9, 1, 8, 5, 2, 6]
        k = 3

        expected = [-1, -1, -1, 5, 4, 4, -1, -1, -1]

        result = self.getAverages(nums, k)

        print1DArray(result)

        return expected == result

    def getAverages(self, nums: List[int], k: int) -> List[int]:
        n = len(nums)
        result = []
        s = 0
        sl = 2 * k + 1
        for i in range(n + k):
            if i < n:
                s += nums[i]
            if i >= sl:
                s -= nums[i - sl]
            if i >= sl - 1 and i < n:
                result.append(s // sl)
            elif i >= k:
                result.append(-1)
        return result
import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3731(Problem):
    def test(self) -> bool:
        nums = [1, 4, 2, 5]

        expected = [3]

        result = self.findMissingElements(nums)

        print1DArray(result)

        return expected == result

    def findMissingElements(self, nums: List[int]) -> List[int]:
        mx = max(nums)
        mn = min(nums)
        l = mx - mn + 1
        present = [False] * l
        for num in nums:
            present[num - mn] = True

        result = []
        for i in range(l):
            if not present[i]:
                result.append(mn + i)
        return result
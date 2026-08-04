import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2905(Problem):
    def test(self) -> bool:
        nums = [5, 1, 4, 1]
        indexDifference = 2
        valueDifference = 4

        expected = [0, 3]

        result = self.findIndices(nums, indexDifference, valueDifference)

        print1DArray(result)

        return expected == result

    def findIndices(self, nums: List[int], indexDifference: int, valueDifference: int) -> List[int]:
        n = len(nums)
        mx = 0
        mn = 0
        for i in range(indexDifference, n):
            id = i - indexDifference
            if nums[mx] < nums[id]:
                mx = id
            elif nums[mn] > nums[id]:
                mn = id
            if abs(nums[i] - nums[mx]) >= valueDifference:
                return [mx, i]
            if abs(nums[i] - nums[mn]) >= valueDifference:
                return [mn, i]

        return [-1, -1]
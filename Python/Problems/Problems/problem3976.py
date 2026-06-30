import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3976(Problem):
    def test(self) -> bool:
        nums = [1, -2, 3, 4, -5]
        k = 2

        expected = 14

        result = self.maxSubarraySum(nums, k)

        print(result)

        return result == expected

    def maxSubarraySum(self, nums: List[int], k: int) -> int:
        curBase = 0
        curMult = 0
        curDiv = 0
        curAfter = 0
        result = -sys.maxsize
        for num in nums:
            mult = num * k
            div = int(num / k)
            curAfter = max(max(curMult + num, curDiv + num), curAfter + num)
            curMult = max(max(curBase + mult, curMult + mult), mult)
            curDiv = max(max(curBase + div, curDiv + div), div)
            curBase = max(curBase + num, num)
            result = max(result, max(max(curBase, curAfter), max(curDiv, curMult)))
        return result
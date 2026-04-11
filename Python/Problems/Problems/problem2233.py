import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2233(Problem):
    def test(self) -> bool:
        nums = [0, 4]
        k = 5

        expected = 20

        result = self.maximumProduct(nums, k)

        print(expected)

        return result == expected

    def maximumProduct(self, nums: List[int], k: int) -> int:
        if len(nums) == 1:
            return nums[0] + k
        que = []
        for num in nums:
            heapq.heappush(que, num)

        while k > 0:
            top = heapq.heappop(que)
            dif = min(k, que[0] + 1 - top)
            heapq.heappush(que, top + dif)
            k -= dif
        result = 1
        for q in que:
            result = result * q % 1000000007
        return result
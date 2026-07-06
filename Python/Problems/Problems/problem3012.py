import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3012(Problem):
    def test(self) -> bool:
        nums = [1, 4, 3, 1]

        expected = 1

        result = self.minimumArrayLength(nums)

        print(result)

        return result == expected

    def minimumArrayLength(self, nums: List[int]) -> int:
        mn = sys.maxsize
        for num in nums:
            mn = min(mn, num)

        for num in nums:
            if num % mn > 0:
                return 1

        cnt = 0
        for num in nums:
            if num == mn:
                cnt += 1
        return (cnt + 1) // 2
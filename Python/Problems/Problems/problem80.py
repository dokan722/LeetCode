import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem80(Problem):
    def test(self) -> bool:
        nums = [1, 1, 1, 2, 2, 3]

        expected = 5

        result = self.removeDuplicates(nums)

        print(result)

        return result == expected

    def removeDuplicates(self, nums: List[int]) -> int:
        cur = 0
        cnt = 0
        prev = nums[0]
        for i in range(len(nums)):
            if nums[i] == prev:
                cnt += 1
            else:
                prev = nums[i]
                cnt = 1

            if cnt <= 2:
                nums[cur] = nums[i]
                cur += 1

        return cur
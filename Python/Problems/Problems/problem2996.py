import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2996(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 2, 5]

        expected = 6

        result = self.missingInteger(nums)

        print(result)

        return result == expected

    def missingInteger(self, nums: List[int]) -> int:
        n = len(nums)
        s = nums[0]
        for i in range(1, n):
            if nums[i] != nums[i - 1] + 1:
                break
            s += nums[i]

        if s > 50:
            return s
        present = [False] * 51
        for num in nums:
            present[num] = True


        for i in range(s, 51):
            if not present[i]:
                return i
        return 51
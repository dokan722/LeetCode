import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem456(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]

        expected = False

        result = self.find132pattern(nums)

        return result == expected

    def find132pattern(self, nums: List[int]) -> bool:
        n = len(nums)
        two = -sys.maxsize
        stack = []
        for i in range(n - 1, -1, -1):
            if nums[i] < two:
                return True
            while stack and nums[i] > stack[-1]:
                two = stack.pop()
            stack.append(nums[i])

        return False
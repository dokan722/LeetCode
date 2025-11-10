import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3542(Problem):
    def test(self) -> bool:
        nums = [3, 1, 2, 1]

        expected = 3

        result = self.minOperations(nums)

        print(result)

        return result == expected

    def minOperations(self, nums: List[int]) -> int:
        stack = []
        result = 0
        for num in nums:
            while stack and stack[-1] >= num:
                if stack.pop() != num:
                    result += 1
            stack.append(num)

        while stack:
            if stack.pop() != 0:
                result += 1

        return result
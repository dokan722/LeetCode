import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2865(Problem):
    def test(self) -> bool:
        heights = [2, 4, 5, 2, 5, 5, 2, 1, 1, 3]

        expected = 23

        result = self.maximumSumOfHeights(heights)

        print(result)

        return result == expected

    def maximumSumOfHeights(self, heights: List[int]) -> int:
        n = len(heights)
        scopes = [0] * n
        result = 0
        stack = []
        total = 0
        for i in range(n):
            curr = heights[i]
            last = i
            while stack and stack[-1][1] >= curr:
                total -= (stack[-1][1] - curr) * (last - stack[-1][0])
                last = stack[-1][0]
                stack.pop()
            stack.append((last, curr))
            total += curr
            scopes[i] = total
        stack.clear()
        total = 0
        for i in range(n - 1, -1, -1):
            curr = heights[i]
            last = i
            while stack and stack[-1][1] >= curr:
                total -= (stack[-1][1] - curr) * (stack[-1][0] - last)
                last = stack[-1][0]
                stack.pop()
            stack.append((last, curr))
            total += curr
            result = max(result, total + scopes[i] - curr)

        return result
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem85(Problem):
    def test(self) -> bool:
        matrix = [['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0']]

        expected = 6

        result = self.maximalRectangle(matrix)

        print(result)

        return result == expected

    def maximalRectangle(self, matrix: List[List[str]]) -> int:
        n = len(matrix)
        m = len(matrix[0])
        h = [0] * m

        result = 0
        stack = []
        for i in range(n):
            for j in range(m):
                if matrix[i][j] == '1':
                    h[j] += 1
                else:
                    h[j] = 0

                while stack and h[stack[-1]] > h[j]:
                    top = stack.pop()
                    l = j - stack[-1] - 1 if stack else j
                    result = max(result, l * h[top])
                stack.append(j)

            while stack:
                top = stack.pop()
                l = m - stack[-1] - 1 if stack else m
                result = max(result, l * h[top])

        return result
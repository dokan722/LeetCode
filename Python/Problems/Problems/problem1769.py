import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1769(Problem):
    def test(self) -> bool:
        boxes = "001011"

        expected = [11, 8, 5, 4, 3, 4]

        result = self.minOperations(boxes)

        print1DArray(result)

        return result == expected

    def minOperations(self, boxes: str) -> List[int]:
        n = len(boxes)
        result = [0] * n
        curr = 0
        balls = 0
        for i in range(n):
            curr += balls
            result[i] += curr
            if boxes[i] == '1':
                balls += 1

        curr = 0
        balls = 0
        for i in range(n - 1, -1, -1):
            curr += balls
            result[i] += curr
            if boxes[i] == '1':
                balls += 1

        return result
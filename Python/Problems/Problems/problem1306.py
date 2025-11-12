import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1306(Problem):
    def test(self) -> bool:
        arr = [4, 2, 3, 0, 3, 1, 2]
        start = 5

        expected = True

        result = self.canReach(arr, start)

        return result == expected

    def canReach(self, arr: List[int], start: int) -> bool:
        n = len(arr)
        visited = [False] * n
        jumpStack = []
        jumpStack.append(start)
        while jumpStack:
            id = jumpStack.pop()
            if not visited[id]:
                if arr[id] == 0:
                    return True
                visited[id] = True
                if id - arr[id] >= 0:
                    jumpStack.append(id - arr[id])
                if id + arr[id] < n:
                    jumpStack.append(id + arr[id])

        return False
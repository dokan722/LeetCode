import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3861(Problem):
    def test(self) -> bool:
        capacity = [1, 5, 3, 7]
        itemSize = 3

        expected = 2

        result = self.minimumIndex(capacity, itemSize)

        print(result)

        return result == expected

    def minimumIndex(self, capacity: list[int], itemSize: int) -> int:
        n = len(capacity)
        minId = -1
        for i in range(n):
            if capacity[i] >= itemSize:
                minId = i
                break
        if minId == -1:
            return minId

        for i in range(minId + 1, n):
            if itemSize <= capacity[i] < capacity[minId]:
                minId = i

        return minId
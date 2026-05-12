import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1665(Problem):
    def test(self) -> bool:
        tasks = [[1, 2], [2, 4], [4, 8]]

        expected = 8

        result = self.minimumEffort(tasks)

        print(result)

        return result == expected

    def minimumEffort(self, tasks: List[List[int]]) -> int:
        n = len(tasks)
        tasks.sort(key=lambda x: x[0] - x[1])
        total = 0
        for i in range(n):
            total += tasks[i][0]
        cur = total
        result = total
        for i in range(n):
            t = tasks[i]
            result += max(0, t[1] - cur)
            cur =max(cur, t[1])
            cur -= t[0]
        return result
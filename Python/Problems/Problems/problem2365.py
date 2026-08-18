import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2365(Problem):
    def test(self) -> bool:
        tasks = [1, 2, 1, 2, 3, 1]
        space = 3

        expected = 9

        result = self.taskSchedulerII(tasks, space)

        print(result)

        return result == expected

    def taskSchedulerII(self, tasks: List[int], space: int) -> int:
        result = 0
        th = dict()
        for t in tasks:
            if t not in th:
                th[t] = 0
            result = max(th[t], result) + 1
            th[t] = result + space

        return result
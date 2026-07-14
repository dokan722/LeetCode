import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3169(Problem):
    def test(self) -> bool:
        days = 10
        meetings = [[5, 7], [1, 3], [9, 10]]

        expected = 2

        result = self.countDays(days, meetings)

        print(result)

        return result == expected

    def countDays(self, days: int, meetings: List[List[int]]) -> int:
        meetings.sort(key=lambda x: x[0])
        cur = 1
        result = 0
        for m in meetings:
            if m[0] > cur:
                result += m[0] - cur
            cur = max(cur, m[1] + 1)
        result += days - cur + 1
        return result
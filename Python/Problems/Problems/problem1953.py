import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1953(Problem):
    def test(self) -> bool:
        milestones = [1, 2, 3]

        expected = 6

        result = self.numberOfWeeks(milestones)

        print(result)

        return expected == result

    def numberOfWeeks(self, milestones: List[int]) -> int:
        sum = 0
        mx = 0
        for m in milestones:
            sum += m
            mx = max(mx, m)

        return 2 * (sum - mx) + 1 if 2 * mx > sum else sum
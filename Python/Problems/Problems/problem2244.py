import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2244(Problem):
    def test(self) -> bool:
        tasks = [2, 2, 3, 3, 2, 4, 4, 4, 4, 4]

        expected = 4

        result = self.minimumRounds(tasks)

        print(result)

        return result == expected

    def minimumRounds(self, tasks: List[int]) -> int:
        counts = dict()
        for task in tasks:
            if task in counts:
                counts[task] += 1
            else:
                counts[task] = 1

        result = 0
        for count in counts.values():
            if count == 1:
                return -1
            mod = count % 3
            if mod == 0:
                result += count // 3
            else:
                result += count // 3 + 1


        return result
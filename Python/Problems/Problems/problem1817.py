import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1817(Problem):
    def test(self) -> bool:
        logs = [[0, 5], [1, 2], [0, 2], [0, 5], [1, 3]]
        k = 5

        expected = [0, 2, 0, 0, 0]

        result = self.findingUsersActiveMinutes(logs, k)

        print1DArray(result)

        return expected == result

    def findingUsersActiveMinutes(self, logs: List[List[int]], k: int) -> List[int]:
        result = [0] * k
        acts = dict()
        for log in logs:
            if log[0] in acts:
                acts[log[0]].add(log[1])
            else:
                acts[log[0]] = set([log[1]])

        for act in acts.values():
            result[len(act) - 1] += 1

        return result
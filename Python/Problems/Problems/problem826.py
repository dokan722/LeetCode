import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem826(Problem):
    def test(self) -> bool:
        difficulty = [2, 4, 6, 8, 10]
        profit = [10, 20, 30, 40, 50]
        worker = [4, 5, 6, 7]

        expected = 100

        result = self.maxProfitAssignment(difficulty, profit, worker)

        print(result)

        return result == expected

    def maxProfitAssignment(self, difficulty: List[int], profit: List[int], worker: List[int]) -> int:
        n = len(difficulty)
        m = len(worker)
        maxSkill = 0
        for i in range(m):
            maxSkill = max(maxSkill, worker[i])
        bestJobs = [0] * (maxSkill + 1)
        for i in range(n):
            if difficulty[i] <= maxSkill:
                bestJobs[difficulty[i]] = max(bestJobs[difficulty[i]], profit[i])

        curr = 0
        for i in range(maxSkill + 1):
            curr = max(curr, bestJobs[i])
            bestJobs[i] = curr
        result = 0
        for i in range(m):
            result += bestJobs[worker[i]]

        return result
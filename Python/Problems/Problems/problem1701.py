from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1701(Problem):
    def test(self) -> bool:
        customers = [[5, 2], [5, 4], [10, 3], [20, 1]]

        expected = 3.25

        result = self.averageWaitingTime(customers)

        print(result)

        return abs(expected - result) < 1e-5

    def averageWaitingTime(self, customers: List[List[int]]) -> float:
        n = len(customers)
        cTime = 0
        totalWait = 0
        for  customer in customers:
            cTime = max(cTime, customer[0])
            cTime += customer[1]
            totalWait += cTime - customer[0]

        return totalWait / n
import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2073(Problem):
    def test(self) -> bool:
        tickets = [5, 1, 1, 1]
        k = 0

        expected = 8

        result = self.timeRequiredToBuy(tickets, k)

        print(result)

        return expected == result

    def timeRequiredToBuy(self, tickets: List[int], k: int) -> int:
        n = len(tickets)
        bar = tickets[k]
        result = bar
        for i in range(k):
            result += min(tickets[i], bar)
        for i in range(k + 1, n):
            result += min(tickets[i], bar - 1)

        return result
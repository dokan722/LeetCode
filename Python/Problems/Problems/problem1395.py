import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1395(Problem):
    def test(self) -> bool:
        rating = [2, 5, 3, 4, 1]

        expected = 3

        result = self.numTeams(rating)

        print(result)

        return result == expected

    def numTeams(self, rating: List[int]) -> int:
        n = len(rating)
        result = 0
        for i in range(n):
            smaller1 = 0
            bigger1 = 0
            for j in range(i):
                if rating[j] < rating[i]:
                    smaller1 += 1
                if rating[j] > rating[i]:
                    bigger1 += 1
            smaller2 = 0
            bigger2 = 0
            for j in range(i + 1, n):
                if rating[j] < rating[i]:
                    smaller2 += 1
                if rating[j] > rating[i]:
                    bigger2 += 1
            result += smaller1 * bigger2 + smaller2 * bigger1

        return result
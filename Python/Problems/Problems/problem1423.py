import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1423(Problem):
    def test(self) -> bool:
        cardPoints = [1, 2, 3, 4, 5, 6, 1]
        k = 3

        expected = 12

        result = self.maxScore(cardPoints, k)

        print(result)

        return result == expected

    def maxScore(self, cardPoints: List[int], k: int) -> int:
        n = len(cardPoints)
        curr = 0
        for i in range(k):
            curr += cardPoints[i]
        result = curr
        for i in range(k):
            curr += cardPoints[n - 1 - i] - cardPoints[k - 1 - i]
            result = max(result, curr)

        return result
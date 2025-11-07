import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2140(Problem):
    def test(self) -> bool:
        questions = [[21, 5], [92, 3], [74, 2], [39, 4], [58, 2], [5, 5], [49, 4], [65, 3]]

        expected = 157

        result = self.mostPoints(questions)

        print(result)

        return result == expected

    def mostPoints(self, questions: List[List[int]]) -> int:
        n = len(questions)
        result = 0
        bestPrev = 0
        dp = [0] * n
        for i in range(n):
            question = questions[i]
            bestPrev = max(bestPrev, dp[i])
            curr = bestPrev + question[0]
            result = max(curr, result)
            next = i + question[1] + 1
            if next < n:
                dp[next] = max(curr, dp[next])

        return result
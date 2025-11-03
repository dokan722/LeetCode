import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1578(Problem):
    def test(self) -> bool:
        colors = "abaac"

        neededTime = [1, 2, 3, 4, 5]

        expected = 3

        result = self.minCost(colors, neededTime)

        print(result)

        return expected == result

    def minCost(self, colors: str, neededTime: List[int]) -> int:
        n = len(colors)
        sum = neededTime[0]
        maxTime = neededTime[0]
        result = 0
        for i in range(1, n):
            if colors[i] != colors[i - 1]:
                if sum != maxTime:
                    result += sum - maxTime
                sum = neededTime[i]
                maxTime = neededTime[i]
            else:
                sum += neededTime[i]
                maxTime = max(maxTime, neededTime[i])
        if sum != maxTime:
            result += sum - maxTime
        return result
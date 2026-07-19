import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2611(Problem):
    def test(self) -> bool:
        reward1 = [1, 1, 3, 4]
        reward2 = [4, 4, 1, 1]
        k = 2

        expected = 15

        result = self.miceAndCheese(reward1, reward2, k)

        print(result)

        return result == expected

    def miceAndCheese(self, reward1: List[int], reward2: List[int], k: int) -> int:
        n = len(reward1)
        ids = [i for i in range(n)]
        diffs = [reward1[i] - reward2[i] for i in range(n)]
        ids.sort(key=lambda i: -diffs[i])
        result = 0
        for i in range(k):
            result += reward1[ids[i]]
        for i in range(k, n):
            result += reward2[ids[i]]
        return result
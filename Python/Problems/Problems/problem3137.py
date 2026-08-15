import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3137(Problem):
    def test(self) -> bool:
        word = "leetcodeleet"
        k = 4

        expected = 1

        result = self.minimumOperationsToMakeKPeriodic(word, k)

        print(result)

        return result == expected

    def minimumOperationsToMakeKPeriodic(self, word: str, k: int) -> int:
        n = len(word)
        counts = dict()
        most = 0
        for i in range(0, n, k):
            cur = word[i:(i + k)]
            if cur in counts:
                counts[cur] += 1
            else:
                counts[cur] = 1
            most = max(most, counts[cur])

        return (n // k) - most
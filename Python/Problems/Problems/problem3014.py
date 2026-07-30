import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3014(Problem):
    def test(self) -> bool:
        word = "abcde"

        expected = 5

        result = self.minimumPushes(word)

        print(result)

        return result == expected

    def minimumPushes(self, word: str) -> int:
        counts = list(Counter(word).values())
        counts.sort(reverse=True)

        result = 0
        for i in range(len(counts)):
            times = (i + 8) // 8
            result += times * counts[i]

        return result
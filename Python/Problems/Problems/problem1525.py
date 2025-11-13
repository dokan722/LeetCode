import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1525(Problem):
    def test(self) -> bool:
        s = "aacaba"

        expected = 2

        result = self.numSplits(s)

        print(result)

        return result == expected

    def numSplits(self, s: str) -> int:
        n = len(s)
        counts = Counter(s)

        result = 0
        currCounts = dict()
        for c in s[:-1]:
            if c in currCounts:
                currCounts[c] += 1
            else:
                currCounts[c] = 1
            if counts[c] > 1:
                counts[c] -= 1
            else:
                del counts[c]
            if len(currCounts) == len(counts):
                result += 1

        return result
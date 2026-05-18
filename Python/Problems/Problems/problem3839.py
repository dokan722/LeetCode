import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3839(Problem):
    def test(self) -> bool:
        words = ["apple", "apply", "banana", "bandit"]
        k = 2

        expected = 2

        result = self.prefixConnected(words, k)

        print(result)

        return result == expected

    def prefixConnected(self, words: List[str], k: int) -> int:
        result = 0
        groups = dict()
        for word in words:
            if len(word) < k:
                continue
            pref = word[:k]
            if pref in groups:
                if groups[pref] == 1:
                    result += 1
                    groups[pref] += 1
            else:
                groups[pref] = 1

        return result
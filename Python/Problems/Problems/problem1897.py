import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1897(Problem):
    def test(self) -> bool:
        words = ["abc", "aabc", "bc"]

        expected = True

        result = self.makeEqual(words)

        return result == expected

    def makeEqual(self, words: List[str]) -> bool:
        n = len(words)
        counts = [0] * 26
        for word in words:
            for c in word:
                counts[ord(c) - ord('a')] += 1
        for i in range(n):
            if counts[i] % n != 0:
                return False

        return True
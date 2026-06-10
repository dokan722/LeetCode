import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3016(Problem):
    def test(self) -> bool:
        word = "abcde"

        expected = 5

        result = self.minimumPushes(word)

        print(result)

        return result == expected

    def minimumPushes(self, word: str) -> int:
        counts = [0] * 26
        for c in word:
            counts[ord(c) - ord('a')] += 1

        counts.sort()
        result = 0
        for i in range(26):
            result += (i // 8 + 1) * counts[25 - i]

        return result
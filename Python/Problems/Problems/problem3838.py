import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter, deque

from .problem import Problem


class Problem3838(Problem):
    def test(self) -> bool:
        words = ["abcd", "def", "xyz"]
        weights = [5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2]

        expected = "rij"

        result = self.mapWordWeights(words, weights)

        print(result)

        return result == expected

    def mapWordWeights(self, words: List[str], weights: List[int]) -> str:
        result = ""
        for w in words:
            s = 0
            for c in w:
                s += weights[ord(c) - ord('a')]
            result += chr(ord('z') - (s % 26))
        return result
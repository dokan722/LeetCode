import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter, deque

from .problem import Problem


class Problem2114(Problem):
    def test(self) -> bool:
        sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"]

        expected = 6

        result = self.mostWordsFound(sentences)

        print(result)

        return result == expected

    def mostWordsFound(self, sentences: List[str]) -> int:
        result = 0
        for s in sentences:
            result = max(result, s.count(' ') + 1)
        return result
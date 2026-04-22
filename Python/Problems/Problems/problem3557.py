import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3557(Problem):
    def test(self) -> bool:
        word = "abcdeafdef"

        expected = 2

        result = self.maxSubstrings(word)

        print(result)

        return result == expected

    def maxSubstrings(self, word: str) -> int:
        n = len(word)
        last = dict()
        result = 0
        for i in range(n):
            if word[i] in last:
                if i - last[word[i]] >= 3:
                    result += 1
                    last.clear()
            else:
                last[word[i]] = i
        return result
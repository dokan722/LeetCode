import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2131(Problem):
    def test(self) -> bool:
        words = ["lc", "cl", "gg"]

        expected = 6

        result = self.longestPalindrome(words)

        print(result)

        return expected == result

    def longestPalindrome(self, words: List[str]) -> int:
        pairs = [[0 for _ in range(26)] for _ in range(26)]
        for word in words:
            pairs[ord(word[0]) - ord('a')][ord(word[1]) - ord('a')] += 1

        sidePairs = 0
        anyOdd = False
        for i in range(26):
            anyOdd = anyOdd or (pairs[i][i] % 2 == 1)
            sidePairs += pairs[i][i] // 2
            for j in range(i + 1, 26):
                sidePairs += min(pairs[i][j], pairs[j][i])

        return sidePairs * 4 + (2 if anyOdd else 0)
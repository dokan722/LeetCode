import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem890(Problem):
    def test(self) -> bool:
        words = ["abc", "deq", "mee", "aqq", "dkd", "ccc"]
        pattern = "abb"

        expected = ["mee", "aqq"]

        result = self.findAndReplacePattern(words, pattern)

        print1DArray(result)

        return expected == result

    def findAndReplacePattern(self, words: List[str], pattern: str) -> List[str]:
        result = []
        ep = self.encode(pattern)
        for word in words:
            if (ep == self.encode(word)):
                result.append(word)

        return result

    def encode(self, word: str) -> str:
        num = 0
        result = ''
        map = dict()
        for c in word:
            if c not in map:
                map[c] = chr(num)
                num += 1
            result += map[c]

        return result
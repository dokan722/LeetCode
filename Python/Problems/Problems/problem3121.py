import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3121(Problem):
    def test(self) -> bool:
        word = "aaAbcBC"

        expected = 3

        result = self.numberOfSpecialChars(word)

        print(result)

        return result == expected

    def numberOfSpecialChars(self, word: str) -> int:
        n = len(word)
        lowers = [0] * 26
        uppers = [0] * 26
        for i in range(n):
            upper = ord(word[i]) <= ord('Z')
            id = ord(word[i]) - ord('A') if upper else ord(word[i]) - ord('a')
            if (upper):
                if uppers[id] == 0:
                    uppers[id] = i + 1
            else:
                lowers[id] = i + 1
        result = 0
        for i in range(26):
            if lowers[i] > 0 and uppers[i] > lowers[i]:
                result += 1
        return result
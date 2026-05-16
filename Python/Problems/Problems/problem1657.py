import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1657(Problem):
    def test(self) -> bool:
        word1 = "abc"
        word2 = "bca"

        expected = True

        result = self.closeStrings(word1, word2)

        return result == expected

    def closeStrings(self, word1: str, word2: str) -> bool:
        n = len(word1)
        if n != len(word2):
            return False
        counts1 = [0] * 26
        counts2 = [0] * 26
        for i in range(n):
            counts1[ord(word1[i]) - ord('a')] += 1
            counts2[ord(word2[i]) - ord('a')] += 1
        for i in range(26):
            if min(counts1[i], counts2[i]) == 0 and max(counts1[i], counts2[i]) != 0:
                return False
        counts1.sort()
        counts2.sort()
        for i in range(26):
            if counts1[i] != counts2[i]:
                return False

        return True
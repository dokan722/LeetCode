import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2840(Problem):
    def test(self) -> bool:
        s1 = "abcdba"
        s2 = "cabdab"

        expected = True

        result = self.checkStrings(s1, s2)

        return expected == result

    def checkStrings(self, s1: str, s2: str) -> bool:
        n = len(s1)
        countsEven1 = [0] * 26
        countsOdd1 = [0] * 26
        countsEven2 = [0] * 26
        countsOdd2 = [0] * 26
        for i in range(n):
            if i % 2 == 0:
                countsEven1[ord(s1[i]) - ord('a')] += 1
                countsEven2[ord(s2[i]) - ord('a')] += 1
            else:
                countsOdd1[ord(s1[i]) - ord('a')] += 1
                countsOdd2[ord(s2[i]) - ord('a')] += 1

        for i in range(26):
            if countsEven1[i] != countsEven2[i] or countsOdd1[i] != countsOdd2[i]:
                return False

        return True
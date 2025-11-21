import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1930(Problem):
    def test(self) -> bool:
        s = "bbcbaba"

        expected = 4

        result = self.countPalindromicSubsequence(s)

        print(result)

        return result == expected

    def countPalindromicSubsequence(self, s: str) -> int:
        n = len(s)
        counts = [0] * 26
        for c in s:
            counts[ord(c) - ord('a')] += 1

        currCounts = [0] * 26
        allPals = set()
        for c in s:
            id = ord(c) - ord('a')
            counts[id] -= 1
            for j in range(26):
                if counts[j] > 0 and currCounts[j] > 0:
                    allPals.add((j, id))
            currCounts[id] += 1

        return len(allPals)
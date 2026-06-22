import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2287(Problem):
    def test(self) -> bool:
        s = "ilovecodingonleetcode"
        target = "code"

        expected = 2

        result = self.rearrangeCharacters(s, target)

        print(result)

        return result == expected

    def rearrangeCharacters(self, s: str, target: str) -> int:
        counts = [0] * 26
        countsT = [0] * 26
        for c in s:
            counts[ord(c) - ord('a')] += 1

        for c in target:
            countsT[ord(c) - ord('a')] += 1

        result = sys.maxsize
        for i in range(26):
            if countsT[i] != 0:
                result = min(result, counts[i] // countsT[i])
        return result
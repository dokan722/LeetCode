import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1456(Problem):
    def test(self) -> bool:
        s = "abciiidef"
        k = 3

        expected = 3

        result = self.maxVowels(s, k)

        print(result)

        return expected == result

    def maxVowels(self, s: str, k: int) -> int:
        n = len(s)
        curr = 0
        for i in range(k):
            if self.isVowel(s[i]):
                curr += 1

        result = curr
        for i in range(k, n):
            curr += 1 if self.isVowel(s[i]) else 0
            curr -= 1 if self.isVowel(s[i - k]) else 0
            result = max(curr, result)

        return result

    def isVowel(self, c: chr) -> bool:
        if c == 'a' or c == 'e' or c == 'i' or c == 'o' or c == 'u':
            return True
        return False
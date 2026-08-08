import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3302(Problem):
    def test(self) -> bool:
        word1 = "vbcca"
        word2 = "abc"

        expected = [0, 1, 2]

        result = self.validSequence(word1, word2)

        print1DArray(result)

        return expected == result

    def validSequence(self, word1: str, word2: str) -> List[int]:
        n = len(word1)
        m = len(word2)
        suf = [0] * n
        c = 0
        j = m - 1
        for i in range(n - 1, -1, -1):
            suf[i] = c
            if j > 0 and word1[i] == word2[j]:
                c += 1
                j -= 1
        result = [0] * m
        j = 0
        i = 0
        changed = False
        while  i < n and j < m:
            if word2[j] == word1[i]:
                result[j] = i
                j += 1
            elif not changed and suf[i] >= m - j - 1:
                result[j] = i
                j += 1
                changed = True
            i += 1

        return result if j == m else []
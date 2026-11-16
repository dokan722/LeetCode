import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2559(Problem):
    def test(self) -> bool:
        words = ["aba", "bcb", "ece", "aa", "e"]
        queries = [[0, 2], [1, 4], [1, 1]]

        expected = [2, 3, 0]

        result = self.vowelStrings(words, queries)

        print1DArray(expected)

        return expected == result

    def vowelStrings(self, words: List[str], queries: List[List[int]]) -> List[int]:
        n = len(words)
        m = len(queries)
        cnt = [0]
        for i in range(1, n + 1):
            cnt.append(cnt[-1])
            word = words[i - 1]
            f = word[0]
            l = word[len(word) - 1]
            if (f == 'a' or f == 'e' or f == 'i' or f == 'o' or f == 'u') and (l == 'a' or l == 'e' or l == 'i' or l == 'o' or l == 'u'):
                cnt[i] += 1

        result = []
        for i in range(m):
            result.append(cnt[queries[i][1] + 1] - cnt[queries[i][0]])

        return result
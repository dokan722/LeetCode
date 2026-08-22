import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem916(Problem):
    def test(self) -> bool:
        words1 = ["amazon", "apple", "facebook", "google", "leetcode"]
        words2 = ["e", "o"]

        expected = ["facebook", "google", "leetcode"]

        result = self.wordSubsets(words1, words2)

        print1DArray(result)

        return expected == result

    def wordSubsets(self, words1: List[str], words2: List[str]) -> List[str]:
        n = len(words1)
        m = len(words2)
        counts1 = []
        counts2 = [0] * 26
        for i in range(n):
            counts1.append([0] * 26)
            for c in words1[i]:
                counts1[i][ord(c) - ord('a')] += 1
        for i in range(m):
            counts = [0] * 26
            for c in words2[i]:
                counts[ord(c) - ord('a')] += 1
            for j in range(26):
                counts2[j] = max(counts2[j], counts[j])
        result = []
        for i in range(n):
            fit = True
            for j in range(26):
                if counts2[j] > counts1[i][j]:
                    fit = False
                    break
            if fit:
                result.append(words1[i])

        return result
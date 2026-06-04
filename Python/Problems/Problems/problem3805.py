import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3805(Problem):
    def test(self) -> bool:
        words = ["ab", "aa", "za", "aa"]

        expected = 2

        result = self.countPairs(words)

        print(result)

        return result == expected

    def countPairs(self, words: List[str]) -> int:
        m = len(words[0])
        result = 0
        counts = dict()
        for w in words:
            a = list(w)
            b = ord(a[0]) - ord('a')
            for i in range(m):
                a[i] = chr((ord(a[i]) - b + 26) % 26)
            s = ''.join(a)
            if s in counts:
                result += counts[s]
                counts[s] += 1
            else:
                counts[s] = 1
        return result
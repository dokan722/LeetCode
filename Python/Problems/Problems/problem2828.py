import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2828(Problem):
    def test(self) -> bool:
        words = ["alice", "bob", "charlie"]
        s = "abc"

        expected = True

        result = self.isAcronym(words, s)

        return expected == result

    def isAcronym(self, words: List[str], s: str) -> bool:
        n = len(words)
        m = len(s)
        if n != m:
            return False
        for i in range(n):
            if words[i][0] != s[i]:
                return False

        return True
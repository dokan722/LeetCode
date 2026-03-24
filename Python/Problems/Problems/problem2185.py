import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2185(Problem):
    def test(self) -> bool:
        words = ["pay", "attention", "practice", "attend"]
        pref = "at"

        expected = 2

        result = self.prefixCount(words, pref)

        print(result)

        return result == expected

    def prefixCount(self, words: List[str], pref: str) -> int:
        n = len(pref)
        result = 0
        for word in words:
            if len(word) >= n and pref == word[:n]:
                result += 1

        return result
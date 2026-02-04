import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2957(Problem):
    def test(self) -> bool:
        word = "zyxyxyz"

        expected = 3

        result = self.removeAlmostEqualCharacters(word)

        print(result)

        return result == expected

    def removeAlmostEqualCharacters(self, word: str) -> int:
        n = len(word)
        changed = [False] * n
        count = 0
        for i in range(1, n):
            if not changed[i - 1] and abs(ord(word[i]) - ord(word[i - 1])) < 2:
                count += 1
                changed[i] = True

        return count
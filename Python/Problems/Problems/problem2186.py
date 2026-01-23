import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2186(Problem):
    def test(self) -> bool:
        s = "leetcode"
        t = "coats"

        expected = 7

        result = self.minSteps(s, t)

        print(result)

        return result == expected

    def minSteps(self, s: str, t: str) -> int:
        counts = [0] * 26
        for c in s:
            counts[ord(c) - ord('a')] += 1
        for c in t:
            counts[ord(c) - ord('a')] -= 1

        result = 0
        for i in range(26):
            result += abs(counts[i])
        return result
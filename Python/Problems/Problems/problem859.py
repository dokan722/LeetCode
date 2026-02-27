import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem859(Problem):
    def test(self) -> bool:
        s = "ab"
        goal = "ba"

        expected = True

        result = self.buddyStrings(s, goal)

        return result == expected

    def buddyStrings(self, s: str, goal: str) -> bool:
        n = len(s)
        if n != len(goal):
            return False
        diff = -1
        swapped = False
        multi = False
        present = [False] * 26
        for i in range(n):
            if not multi:
                id = ord(s[i]) - ord('a')
                if present[id]:
                    multi = True
                else:
                    present[id] = True
            if s[i] != goal[i]:
                if swapped:
                    return False
                if diff == -1:
                    diff = i
                else:
                    if s[i] != goal[diff] or s[diff] != goal[i]:
                        return False
                    swapped = True

        return swapped or (diff == -1 and multi)
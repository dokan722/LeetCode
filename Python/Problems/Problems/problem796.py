import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem796(Problem):
    def test(self) -> bool:
        s = "abcde"
        goal = "cdeab"

        expected = True

        result = self.rotateString(s, goal)

        print(result)

        return expected == result

    def rotateString(self, s: str, goal: str) -> bool:
        n = len(s)
        if n != len(goal):
            return False
        for i in range(n):
            match = True
            for j in range(n):
                if goal[j] != s[(i + j) % n]:
                    match = False
                    break
            if match:
                return True

        return False
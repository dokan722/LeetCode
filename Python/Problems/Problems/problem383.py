import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem383(Problem):
    def test(self) -> bool:
        ransomNote = "a"
        magazine = "b"

        expected = False

        result = self.canConstruct(ransomNote, magazine)

        return expected == result

    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        ransomCount = Counter(ransomNote)
        magazineCount = Counter(magazine)
        for c in ransomCount.items():
            if c[1] > magazineCount.get(c[0], 0):
                return False


        return True
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1625(Problem):
    def test(self) -> bool:
        s = "5525"
        a = 9
        b = 2

        expected = "2050"

        result = self.findLexSmallestString(s, a, b)

        print(result)

        return expected == result

    def findLexSmallestString(self, s: str, a: int, b: int) -> str:
        present = set()
        self.findRec(s, a, b, present)
        pList = list(present)
        pList.sort()
        return pList[0]

    def findRec(self, s: str, a: int, b: int, present: Set[str]) -> None:
        if s in present:
            return
        present.add(s)

        n = len(s)
        added = ''
        for i in range(n):
            if i % 2 == 0:
                added += s[i]
            else:
                added += chr(ord('0') + (ord(s[i]) - ord('0') + a) % 10)
        rotated = s[(n - b):] + s[0:(n - b)]
        self.findRec(added, a, b, present)
        self.findRec(rotated, a, b, present)
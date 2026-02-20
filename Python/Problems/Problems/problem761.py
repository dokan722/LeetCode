import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem761(Problem):
    def test(self) -> bool:
        s = "11011000"

        expected = "11100100"

        result = self.makeLargestSpecial(s)

        print(result)

        return result == expected

    def makeLargestSpecial(self, s: str) -> str:
        n = len(s)
        result = []

        level = 0
        last = 0
        for i in range(n):
            if s[i] == '0':
                level -= 1
            else:
                level += 1
            if level == 0:
                result.append("1" + self.makeLargestSpecial(s[(last + 1):i]) + "0")
                last = i + 1

        result.sort(reverse = True)
        return ''.join(result)
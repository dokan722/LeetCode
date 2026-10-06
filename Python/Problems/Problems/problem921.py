import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem921(Problem):
    def test(self) -> bool:
        s = "())"

        expected = 1

        result = self.minAddToMakeValid(s)

        print(result)

        return result == expected

    def minAddToMakeValid(self, s: str) -> int:
        result = 0
        cur = 0
        for c in s:
            if c == '(':
                cur += 1
            else:
                if cur == 0:
                    result += 1
                else:
                    cur -= 1
        return result + cur
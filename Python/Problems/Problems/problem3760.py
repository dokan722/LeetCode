import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3760(Problem):
    def test(self) -> bool:
        s = "abab"

        expected = 2

        result = self.maxDistinct(s)

        print(result)

        return result == expected

    def maxDistinct(self, s: str) -> int:
        return len(set(s))
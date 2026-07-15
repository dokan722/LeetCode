import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3658(Problem):
    def test(self) -> bool:
        n = 4

        expected = 4

        result = self.gcdOfOddEvenSums(n)

        print(result)

        return result == expected

    def gcdOfOddEvenSums(self, n: int) -> int:
        return n
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2645(Problem):
    def test(self) -> bool:
        word = "b"

        expected = 2

        result = self.addMinimum(word)

        print(result)

        return result == expected

    def addMinimum(self, word: str) -> int:
        prev = 0
        result = 0
        for c in word:
            if c == 'a':
                if prev == 0:
                    prev = 1
                elif prev == 1:
                    result += 2
                else:
                    result += 1
                    prev = 1
            elif c == 'b':
                if prev == 0:
                    result += 1
                    prev = 2
                elif prev == 1:
                    prev = 2
                else:
                    result += 2
            else:
                if prev == 0:
                    result += 2
                elif prev == 1:
                    result += 1
                    prev = 0
                else:
                    prev = 0


        return result + ord('c') - ord(word[-1])
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2381(Problem):
    def test(self) -> bool:
        s = "abc"
        shifts = [[0, 1, 0], [1, 2, 1], [0, 2, 1]]

        expected = "ace"

        result = self.shiftingLetters(s, shifts)

        print(result)

        return result == expected

    def shiftingLetters(self, s: str, shifts: List[List[int]]) -> str:
        n = len(s)
        sweep = [0] * (n + 1)
        for shift in shifts:
            val = 1 if shift[2] == 1 else -1
            sweep[shift[0]] += val
            sweep[shift[1] + 1] -= val

        arr = []
        cur = 0
        for i in range(n):
            cur += sweep[i]
            arr.append(chr((((ord(s[i]) - ord('a') + cur) % 26 + 26) % 26 + ord('a'))))

        return ''.join(arr)
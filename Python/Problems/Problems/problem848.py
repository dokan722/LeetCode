import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem848(Problem):
    def test(self) -> bool:
        s = "abc"
        shifts = [3, 5, 9]

        expected = "rpl"

        result = self.shiftingLetters(s, shifts)

        print(result)

        return result == expected

    def shiftingLetters(self, s: str, shifts: List[int]) -> str:
        n = len(s)
        cur = 0
        arr = [''] * n
        for i in range(n - 1, -1, -1):
            cur += shifts[i]
            arr[i] = chr(((ord(s[i]) - ord('a') + cur) % 26 + ord('a')))
        return ''.join(arr)
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3675(Problem):
    def test(self) -> bool:
        s = "yz"

        expected = 2

        result = self.minOperations(s)

        print(result)

        return result == expected

    def minOperations(self, s: str) -> int:
        present = [False] * 26
        for c in s:
            present[ord(c) - ord('a')] = True
        prev = -1
        result = 0
        for i in range(1, 26):
            if present[i]:
                if prev == -1:
                    prev = i
                else:
                    result += i - prev
                    prev = i

        return result + ( 26 - prev if prev != -1 else 0)
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2405(Problem):
    def test(self) -> bool:
        s = "abacaba"

        expected = 4

        result = self.partitionString(s)

        print(result)

        return result == expected

    def partitionString(self, s: str) -> int:
        n = len(s)
        present = [False] * 26
        result = 1

        for i in range(n):
            id = ord(s[i]) - ord('a')
            if present[id]:
                result += 1
                present = [False] * 26
            present[id] = True

        return result
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1758(Problem):
    def test(self) -> bool:
        s = "0100"

        expected = 1

        result = self.minOperations(s)

        print(result)

        return result == expected

    def minOperations(self, s: str) -> int:
        count = 0
        wantOne = True
        for c in s:
            if wantOne:
                count += 1 if c == '0' else 0
                wantOne = False
            else:
                count += 0 if c == '0' else 1
                wantOne = True

        return min(count, len(s) - count)
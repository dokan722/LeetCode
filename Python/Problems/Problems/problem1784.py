import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1784(Problem):
    def test(self) -> bool:
        s = "1001"

        expected = False

        result = self.checkOnesSegment(s)

        return expected == result

    def checkOnesSegment(self, s: str) -> bool:
        n = len(s)
        for i in range(n - 1, -1, -1):
            if s[i] == '1' and s[i - 1] == '0':
                return False

        return True
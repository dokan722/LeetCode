import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2938(Problem):
    def test(self) -> bool:
        s = "101"

        expected = 1

        result = self.minimumSteps(s)

        print(result)

        return result == expected

    def minimumSteps(self, s: str) -> int:
        n = len(s)
        l = 0
        result = 0
        for i in range(n):
            if s[i] == '0':
                result += i - l
                l += 1


        return result
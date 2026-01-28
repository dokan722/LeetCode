import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1529(Problem):
    def test(self) -> bool:
        target = "10111"

        expected = 3

        result = self.minFlips(target)

        print(result)

        return expected == result

    def minFlips(self, target: str) -> int:
        waitingZero = False
        count = 0
        for c in target:
            if c == '1':
                waitingZero = True
            else:
                if waitingZero:
                    count += 1
                waitingZero = False

        return 2 * count + (1 if waitingZero else 0)
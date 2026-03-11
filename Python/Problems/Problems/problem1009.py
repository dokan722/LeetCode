import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1009(Problem):
    def test(self) -> bool:
        n = 10

        expected = 5

        result = self.bitwiseComplement(n)

        print(result)

        return result == expected

    def bitwiseComplement(self, n: int) -> int:
        if n == 0:
            return 1
        result = 0
        len = 0
        while n > 0:
            if n % 2 == 0:
                result += 1 << len
            len += 1
            n >>= 1
        return result
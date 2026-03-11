import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2177(Problem):
    def test(self) -> bool:
        num = 33

        expected = [10, 11, 12]

        result = self.sumOfThree(num)

        print1DArray(result)

        return expected == result

    def sumOfThree(self, num: int) -> List[int]:
        if num % 3 != 0:
            return []
        mid = num // 3
        return [mid - 1, mid, mid + 1]
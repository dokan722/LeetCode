import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem119(Problem):
    def test(self) -> bool:
        rowIndex = 3

        expected = [1, 3, 3, 1]

        result = self.getRow(rowIndex)

        print1DArray(result)

        return expected == result

    def getRow(self, rowIndex: int) -> List[int]:
        result = [0] * (rowIndex + 1)
        result[0] = 1
        result[rowIndex] = 1
        for i in range(1, rowIndex + 1):
            prev = result[0]
            for j in range(1, rowIndex):
                curr = result[j]
                result[j] = prev + result[j]
                prev = curr
        return result
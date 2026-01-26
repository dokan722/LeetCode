import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1200(Problem):
    def test(self) -> bool:
        arr = [3, 8, -10, 23, 19, -4, -14, 27]

        expected = [[-14, -10], [19, 23], [23, 27]]

        result = self.minimumAbsDifference(arr)

        print2DArray(result)

        return expected == result

    def minimumAbsDifference(self, arr: List[int]) -> List[List[int]]:
        arrLength = len(arr)
        arr.sort()
        minDiff = arr[1] - arr[0]
        result = [[arr[0], arr[1]]]
        for i in range(2, arrLength):
            curDiff = arr[i] - arr[i - 1]
            if curDiff == minDiff:
                result.append([arr[i - 1], arr[i]])
            elif curDiff < minDiff:
                minDiff = curDiff
                result = [[arr[i - 1], arr[i]]]

        return result
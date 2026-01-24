import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1218(Problem):
    def test(self) -> bool:
        arr = [1, 5, 7, 8, 5, 3, 4, 2, 1]
        difference = -2

        expected = 4

        result = self.longestSubsequence(arr, difference)

        print(result)

        return result == expected

    def longestSubsequence(self, arr: List[int], difference: int) -> int:
        subsequences = dict()
        maxLength = 0
        for num in arr:
            prev = num - difference
            if prev in subsequences:
                subsequences[num] = subsequences[prev] + 1
            else:
                subsequences[num] = 1
            maxLength = max(maxLength, subsequences[num])

        return maxLength
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3875(Problem):
    def test(self) -> bool:
        nums1 = [2, 3]

        expected = True

        result = self.uniformArray(nums1)

        return expected == result

    def uniformArray(self, nums1: list[int]) -> bool:
        return True
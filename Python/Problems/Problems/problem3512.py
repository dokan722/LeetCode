import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3512(Problem):
    def test(self) -> bool:
        nums = [3, 9, 7]
        k = 5

        expected = 4

        result = self.minOperations(nums, k)

        print(result)

        return expected == result

    def minOperations(self, nums: List[int], k: int) -> int:
        return sum(nums) % k
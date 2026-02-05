import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3379(Problem):
    def test(self) -> bool:
        nums = [3, -2, 1, 1]

        expected = [1, 1, 1, 3]

        result = self.constructTransformedArray(nums)

        print1DArray(result)

        return expected == result

    def constructTransformedArray(self, nums: List[int]) -> List[int]:
            return [nums[((i + nums[i]) % len(nums) + len(nums)) % len(nums)] for i in range(len(nums))]
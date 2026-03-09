import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3804(Problem):
    def test(self) -> bool:
        nums = [-1, 1, 0]

        expected = 5

        result = self.centeredSubarrays(nums)

        print(result)

        return result == expected

    def centeredSubarrays(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(n):
            sum = 0
            present = set()
            for j in range(i, n):
                sum += nums[j]
                present.add(nums[j])
                if sum in present:
                    result += 1

        return result
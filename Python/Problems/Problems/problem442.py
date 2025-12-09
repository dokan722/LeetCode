import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem442(Problem):
    def test(self) -> bool:
        nums = [4, 3, 2, 7, 8, 2, 3, 1]

        expected = [2, 3]

        result = self.findDuplicates(nums)

        print1DArray(result)

        return expected == result

    def findDuplicates(self, nums: List[int]) -> List[int]:
        n = len(nums)
        result = []
        for i in range(n):
            id = abs(nums[i]) - 1
            if nums[id] < 0:
                result.append(abs(nums[i]))
            else:
                nums[id] = -nums[id]

        return result
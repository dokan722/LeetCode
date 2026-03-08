import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1980(Problem):
    def test(self) -> bool:
        nums = ["111", "011", "001"]

        expected = "000"

        result = self.findDifferentBinaryString(nums)

        print(result)

        return result == expected

    def findDifferentBinaryString(self, nums: List[str]) -> str:
        n = len(nums)
        result = ""
        for i in range(n):
            result += '1' if nums[i][i] == '0' else '0'

        return result
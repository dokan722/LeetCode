import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3583(Problem):
    def test(self) -> bool:
        nums = [8, 4, 2, 8, 4]

        expected = 2

        result = self.specialTriplets(nums)

        print(result)

        return expected == result

    def specialTriplets(self, nums: List[int]) -> int:
        countsAll = dict()
        countsCurr = dict()
        mod = 1000000007
        for num in nums:
            if num in countsAll:
                countsAll[num] += 1
            else:
                countsAll[num] = 1
                countsCurr[num] = 0

        result = 0
        for num in nums:
            countsAll[num] -= 1
            exp = 2 * num
            if exp in countsAll:
                result = (result + countsAll[exp] * countsCurr[exp]) % mod
            countsCurr[num] += 1

        return result
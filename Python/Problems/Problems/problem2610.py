import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2610(Problem):
    def test(self) -> bool:
        nums = [1, 3, 4, 1, 2, 3, 1]

        expected = [[1, 3, 4, 2], [1, 3], [1]]

        result = self.findMatrix(nums)

        print2DArray(result)

        return expected == result

    def findMatrix(self, nums: List[int]) -> List[List[int]]:
        counts = [0] * 201
        result = []
        for num in nums:
            row = counts[num]
            if len(result) <= row:
                result.append([num])
            else:
                result[row].append(num)
            counts[num] += 1

        return result
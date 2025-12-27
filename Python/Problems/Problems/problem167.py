import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem167(Problem):
    def test(self) -> bool:
        numbers = [2, 7, 11, 15]
        target = 9

        expected = [1, 2]

        result = self.twoSum(numbers, target)

        print1DArray(result)

        return expected == result

    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        left = 0
        right = len(numbers) - 1
        while left < right:
            if target < numbers[left] + numbers[right]:
                right -= 1
            elif target > numbers[left] + numbers[right]:
                left += 1
            else:
                return [left + 1, right + 1]

        return None
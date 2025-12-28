import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem75(Problem):
    def test(self) -> bool:
        nums = [2, 0, 2, 1, 1, 0]

        expected = [0, 0, 1, 1, 2, 2]

        self.sortColors(nums)

        print1DArray(nums)

        return nums == expected

    def sortColors(self, nums: List[int]) -> None:
        left = 0
        mid = 0
        right = len(nums) - 1
        while mid < right:
            if nums[mid] == 0:
                nums[left], nums[mid] = nums[mid], nums[left]
                left += 1
                mid += 1
            elif nums[mid] == 1:
                mid += 1
            else:
                nums[mid], nums[right] = nums[right], nums[mid]
                right -= 1
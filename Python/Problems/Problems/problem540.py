import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem540(Problem):
    def test(self) -> bool:
        nums = [1, 1, 2, 3, 3, 4, 4, 8, 8]

        expected = 2

        result = self.singleNonDuplicate(nums)

        print(result)

        return result == expected

    def singleNonDuplicate(self, nums: List[int]) -> int:
        n = len(nums)
        l = 0
        r = n - 1
        while l < r:
            mid = (l + r) // 2
            if nums[mid] == nums[mid + 1]:
                if mid % 2 == 0:
                    l = mid + 2
                else:
                    r = mid - 1
            elif nums[mid] == nums[mid - 1]:
                if (mid % 2 == 1):
                    l = mid + 1
                else:
                    r = mid - 2
            else:
                return nums[mid]
        return nums[l]
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem33(Problem):
    def test(self) -> bool:
        nums = [4, 5, 6, 7, 0, 1, 2]
        target = 0

        expected = 4

        result = self.search(nums, target)

        print(result)

        return result == expected

    def search(self, nums: List[int], target: int) -> int:
        l = 0
        r = len(nums) - 1
        while l < r:
            mid = (l + r) // 2
            if nums[mid] == target:
                return mid

            if nums[mid] >= nums[l]:
                if nums[mid] < target:
                    l = mid + 1
                elif nums[l] <= target:
                    r = mid - 1
                else:
                    l = mid + 1
            else:
                if target < nums[mid]:
                    r = mid - 1
                elif target <= nums[r]:
                    l = mid + 1
                else:
                    r = mid - 1

        return l if nums[l] == target else -1
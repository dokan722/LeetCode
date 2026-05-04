import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem300(Problem):
    def test(self) -> bool:
        nums = [10, 9, 2, 5, 3, 7, 101, 18]

        expected = 4

        result = self.lengthOfLIS(nums)

        print(result)

        return result == expected

    def lengthOfLIS(self, nums: List[int]) -> int:
        subs = []
        for num in nums:
            l = 0
            r = len(subs) - 1
            mid = 0
            while l <= r:
                mid = (l + r) // 2
                if num > subs[mid]:
                    l = mid + 1
                else:
                    r = mid - 1
            if l == len(subs):
                subs.append(num)
            else:
                subs[l] = num
        return len(subs)
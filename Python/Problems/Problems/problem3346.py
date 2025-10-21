import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3346(Problem):
    def test(self) -> bool:
        nums = [33, 3, 86, 86, 114]
        k = 20
        numOperations = 4

        expected = 3

        result = self.maxFrequency(nums, k, numOperations)

        print(result)

        return result == expected

    def maxFrequency(self, nums: List[int], k: int, numOperations: int) -> int:
        nums.sort()
        n = len(nums)
        left = 0
        leftBig = 0
        right = 0
        rightBig = 0
        curr = 0
        result = 0
        while curr < n:
            val = nums[curr]
            start = curr
            while curr < n and nums[curr] == val:
                curr += 1
            while right < n and nums[right] <= val + k:
                right += 1
            while rightBig < n and nums[rightBig] <= val + k * 2:
                rightBig += 1
            while nums[left] < val - k:
                left += 1
            while nums[leftBig] < val - 2 * k:
                leftBig +=1
            currLen = curr - start
            inRange = right - left
            inRangeLeft = curr - leftBig
            inRangeRight = rightBig - start
            makeEqual = currLen + min(numOperations, inRange - currLen)
            makeOther = min(numOperations, max(inRangeLeft, inRangeRight))
            result = max(result, max(makeEqual, makeOther))


        return result
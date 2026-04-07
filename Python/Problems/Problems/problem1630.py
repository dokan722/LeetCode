import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1630(Problem):
    def test(self) -> bool:
        nums = [1, 2, 10, -6, -7, 8, 16, 0, 0, 10, 20, 15, -2, -3, -1, -4, -4, -8, -2]
        l = [14, 5, 11, 15, 12, 13, 9, 7, 0]
        r = [15, 8, 14, 18, 15, 16, 12, 8, 1]

        expected = [True,False,False,False,True,False,False,True,True]

        result = self.checkArithmeticSubarrays(nums, l, r)

        print1DArray(result)

        return expected == result

    def checkArithmeticSubarrays(self, nums: List[int], l: List[int], r: List[int]) -> List[bool]:
        m = len(l)
        result = [False] * m
        for i in range(m):
            mn = sys.maxsize
            mx = -sys.maxsize
            for j in range(l[i], r[i] + 1):
                mn = min(mn, nums[j])
                mx = max(mx, nums[j])
            ln = r[i] - l[i] + 1
            if mn == mx:
                result[i] = True
            elif (mx - mn) % (ln - 1) == 0:
                present = [False] * ln
                res = True
                d = (mx - mn) // (ln - 1)
                for j in range(l[i], r[i] + 1):
                    if (nums[j] - mn) %d != 0 or present[(nums[j] - mn) // d]:
                        res = False
                        break
                    present[(nums[j] - mn) // d] = True

                result[i] = res
        return result
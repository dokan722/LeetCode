import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1664(Problem):
    def test(self) -> bool:
        nums = [2, 1, 6, 4]

        expected = 1

        result = self.waysToMakeFair(nums)

        print(result)

        return result == expected

    def waysToMakeFair(self, nums: List[int]) -> int:
        n = len(nums)
        evenSum = 0
        oddSum = 0
        for i in range(n):
            if i % 2 == 0:
                evenSum += nums[i]
            else:
                oddSum += nums[i]

        currEven = 0
        currOdd = 0
        result = 0
        for i in range(n):
            if i % 2 == 0:
                if currEven + (oddSum - currOdd) == currOdd + (evenSum - currEven - nums[i]):
                    result += 1
                currEven += nums[i]
            else:
                if currEven + (oddSum - currOdd - nums[i]) == currOdd + (evenSum - currEven):
                    result += 1
                currOdd += nums[i]

        return result
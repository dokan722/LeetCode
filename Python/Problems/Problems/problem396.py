from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem396(Problem):
    def test(self) -> bool:
        nums = [4, 3, 2, 6]

        expected = 26

        result = self.maxRotateFunction(nums)

        print(result)

        return expected == result

    def maxRotateFunction(self, nums: List[int]) -> int:
        n = len(nums)
        sum = 0
        fvalue = 0
        for i in range(n):
            sum += nums[i]
            fvalue += nums[i] * i

        result = fvalue

        for i in range(1, n):
            fvalue += sum
            fvalue -= nums[n - i] * n
            result = max(result, fvalue)

        return result
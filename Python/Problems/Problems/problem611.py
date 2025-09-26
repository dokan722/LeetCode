from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem611(Problem):
    def test(self) -> bool:
        nums = [4, 2, 3, 4]

        expected = 4

        result = self.triangleNumber(nums)

        print(result)

        return expected == result

    def triangleNumber(self, nums: List[int]) -> int:
        n = len(nums)
        if n < 3:
            return 0
        counts = [0] * 1001
        presentNums = set()
        for num in nums:
            counts[num] += 1
            presentNums.add(num)
        if 0 in presentNums:
            presentNums.remove(0)

        smallerOrEqual = [0] * 1001
        smallerOrEqual[1] = counts[1]
        for i in range(2, 1001):
            smallerOrEqual[i] = smallerOrEqual[i - 1] + counts[i]


        result = 0
        for num1 in presentNums:
            for num2 in presentNums:
                tooSmall = max(num1, num2) - min(num1, num2)
                num3Poss = n - 2 if num1 + num2 > 1000 else smallerOrEqual[num1 + num2 - 1] - 2
                num3Poss -= smallerOrEqual[tooSmall] - (1 if tooSmall >= min(num1, num2) else 0)
                if num1 != num2:
                    result += counts[num1] * counts[num2] * num3Poss
                else:
                    result += (counts[num1] - 1) * counts[num2] * num3Poss

        return result // 6
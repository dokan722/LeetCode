from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2197(Problem):
    def test(self) -> bool:
        nums = [6, 4, 3, 2, 7, 6, 2]

        expected = [12, 7, 6]

        result = self.replaceNonCoprimes(nums)

        print1DArray(result)

        return expected == result

    def replaceNonCoprimes(self, nums: List[int]) -> List[int]:
        result = []
        for num in nums:
            next = num
            while len(result) > 0:
                last = result[-1]
                gcd = self.gcd(last, next)
                if gcd == 1:
                    break
                next = last * next // gcd
                result.pop()
            result.append(next)

        return result

    def gcd(self, a: int, b: int) -> int:
        while b != 0:
            temp = b
            b = a % b
            a = temp

        return a
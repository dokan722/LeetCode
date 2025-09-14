from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem3517(Problem):
    def test(self) -> bool:
        s = "babab"

        expected = "abbba"

        result = self.smallestPalindrome(s)

        print(result)

        return expected == result

    def smallestPalindrome(self, s: str) -> str:
        n = len(s)
        isOdd = n % 2 == 1
        count = dict(Counter(s))

        middle = ""
        if isOdd:
            for k, v in count.items():
                if v % 2 == 1:
                    middle += k
                    break

        half = ""
        keys = list(count.keys())
        keys.sort()
        for k in keys:
            half += k * (count[k] // 2)


        return half + middle + half[::-1]
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem443(Problem):
    def test(self) -> bool:
        chars = ['a', 'a', 'b', 'b', 'c', 'c', 'c']

        expected1 = 6
        expected2 = ['a', '2', 'b', '2', 'c', '3']
        result = self.compress(chars)
        charResult = chars[:result]

        print(result)
        print1DArray(charResult)

        return result == expected1 and charResult == expected2

    def compress(self, chars: List[str]) -> int:
        n = len(chars)
        if n < 2:
            return n
        j = 0
        start = 0
        for i in range(1, n):
            if chars[i] != chars[i - 1]:
                l = i - start
                chars[j] = chars[i - 1]
                j += 1
                if l > 1:
                    for  digit in str(l):
                        chars[j] = digit
                        j += 1
                start = i
        fl = (n - start)
        chars[j] = chars[n - 1]
        j += 1
        if fl > 1:
            for digit in str(fl):
                chars[j] = digit
                j += 1

        return j
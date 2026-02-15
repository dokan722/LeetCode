import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem67(Problem):
    def test(self) -> bool:
        a = "1010"
        b = "1011"

        expected = "10101"

        result = self.addBinary(a, b)

        print(result)

        return result == expected

    def addBinary(self, a: str, b: str) -> str:
        n = len(a)
        m = len(b)
        big = max(n, m)
        result = ['0'] * (big + 1)
        carry = 0
        for i in range(big + 1):
            first = ord(a[n - i - 1]) - ord('0') if  i < n else 0
            second = ord(b[m - i - 1]) - ord('0') if i < m else 0
            total = carry + first + second
            result[big - i] = chr(total % 2 + ord('0'))
            carry = 1 if total > 1 else 0
        resultStr = ''.join(result)
        return resultStr[1:] if resultStr[0] == '0' else resultStr
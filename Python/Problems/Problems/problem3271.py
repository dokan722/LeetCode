import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3271(Problem):
    def test(self) -> bool:
        s = "abcd"
        k = 2

        expected = "bf"

        result = self.stringHash(s, k)

        print(result)

        return result == expected

    def stringHash(self, s: str, k: int) -> str:
        return ''.join([chr(sum([ord(x) - ord('a') for x in s[i*k:(i+1)*k]]) % 26 + ord('a')) for i in range(len(s) // k)])
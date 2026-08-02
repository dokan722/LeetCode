import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3849(Problem):
    def test(self) -> bool:
        s = "101"
        t = "011"

        expected = "110"

        result = self.maximumXor(s, t)

        print(result)

        return result == expected

    def maximumXor(self, s: str, t: str) -> str:
        n = len(s)
        ones = t.count("1")
        zeros = n - ones
        result = []
        for i in range(n):
            if s[i] == '0':
                if ones > 0:
                    result.append('1')
                    ones -= 1
                else:
                    result.append('0')
                    zeros -= 1
            else:
                if zeros > 0:
                    result.append('1')
                    zeros -= 1
                else:
                    result.append('0')
                    ones -= 1

        return ''.join(result)
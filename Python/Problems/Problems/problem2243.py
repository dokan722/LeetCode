import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2243(Problem):
    def test(self) -> bool:
        s = "11111222223"
        k = 3

        expected = "135"

        result = self.digitSum(s, k)

        print(result)

        return result == expected

    def digitSum(self, s: str, k: int) -> str:
        while len(s) > k:
            groups = (len(s) + k - 1) // k
            next = ""
            for i in range(groups):
                cur = 0
                sh = i * k
                size = min(k, len(s) - sh)
                for j in range(size):
                    cur += ord(s[sh + j]) - ord('0')
                next += str(cur)
            s = next

        return s
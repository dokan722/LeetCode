import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3234(Problem):
    def test(self) -> bool:
        s = "00011"

        expected = 5

        result = self.numberOfSubstrings(s)

        print(result)

        return result == expected

    def numberOfSubstrings(self, s: str) -> int:
        n = len(s)
        ids = [0] * (n + 1)
        ids[0] = -1
        for i in range(n):
            if i == 0 or s[i - 1] == '0':
                ids[i + 1] = i
            else:
                ids[i + 1] = ids[i]
        result = 0
        for i in range(1, n + 1):
            zeros = 1 if s[i - 1] == '0' else 0
            j = i
            while j > 0 and zeros * zeros <= n:
                ones = (i - ids[j]) - zeros
                if zeros * zeros <= ones:
                    result += min(j - ids[j], ones - zeros * zeros + 1)
                j = ids[j]
                zeros += 1

        return result
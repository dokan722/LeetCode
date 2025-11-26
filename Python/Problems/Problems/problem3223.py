import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3223(Problem):
    def test(self) -> bool:
        s = "abaacbcbb"

        expected = 5

        result = self.minimumLength(s)

        print(result)

        return result == expected

    def minimumLength(self, s: str) -> int:
        counts = [0] * 26
        for c in s:
            counts[ord(c) - ord('a')] += 1

        result = 0
        for count in counts:
            if count > 0:
                result += 1 + (1 if count % 2 == 0 else 0)

        return result
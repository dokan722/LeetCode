import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2515(Problem):
    def test(self) -> bool:
        words = ["hello", "i", "am", "leetcode", "hello"]
        target = "hello"
        startIndex = 1

        expected = 1

        result = self.closestTarget(words, target, startIndex)

        print(result)

        return result == expected

    def closestTarget(self, words: List[str], target: str, startIndex: int) -> int:
        n = len(words)
        result = sys.maxsize
        for i in range(n):
            cur = (startIndex + i) % n
            if words[cur] == target:
                result = min(result, min(i, n - i))

        return -1 if result == sys.maxsize else result
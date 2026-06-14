import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem318(Problem):
    def test(self) -> bool:
        words = ["abcw", "baz", "foo", "bar", "xtfn", "abcdef"]

        expected = 16

        result = self.maxProduct(words)

        print(result)

        return result == expected

    def maxProduct(self, words: List[str]) -> int:
        n = len(words)
        result = 0
        masks = []
        for i in range(n):
            mask = 0
            for c in words[i]:
                mask |= 1 << (ord(c) - ord('a'))
            masks.append(mask)
        for i in range(n):
            for j in range(i + 1, n):
                if (masks[i] & masks[j]) == 0:
                    result = max(result, len(words[i]) * len(words[j]))

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3324(Problem):
    def test(self) -> bool:
        target = "abc"

        expected = ["a", "aa", "ab", "aba", "abb", "abc"]

        result = self.stringSequence(target)

        print1DArray(result)

        return expected == result

    def stringSequence(self, target: str) -> List[str]:
        result = []
        curr = ""
        for c in target:
            for i in range(ord('a'), ord(c) + 1):
                result.append(curr + chr(i))

            curr += c

        return result
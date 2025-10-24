import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem946(Problem):
    def test(self) -> bool:
        pushed = [1, 2, 3, 4, 5]
        popped = [4, 5, 3, 2, 1]

        expected = True

        result = self.validateStackSequences(pushed, popped)

        return expected == result

    def validateStackSequences(self, pushed: List[int], popped: List[int]) -> bool:
        n = len(pushed)
        firstPopped = 0
        reverseStack = []
        for i in range(n):
            reverseStack.append(pushed[i])
            while reverseStack and reverseStack[-1] == popped[firstPopped]:
                reverseStack.pop()
                firstPopped += 1

        return not reverseStack
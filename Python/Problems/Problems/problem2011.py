import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2011(Problem):
    def test(self) -> bool:
        operations = ["--X", "X++", "X++"]
        expected = 1

        result = self.finalValueAfterOperations(operations)

        print(result)

        return result == expected

    def finalValueAfterOperations(self, operations: List[str]) -> int:
        result = 0
        for o in operations:
            if o == "X++" or o == "++X":
                result += 1
            else:
                result -= 1

        return result
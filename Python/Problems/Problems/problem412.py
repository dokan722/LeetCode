import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem412(Problem):
    def test(self) -> bool:
        n = 5

        expected = ["1", "2", "Fizz", "4", "Buzz"]

        result = self.fizzBuzz(n)

        print1DArray(result)

        return expected == result

    def fizzBuzz(self, n: int) -> List[str]:
        result = []
        for i in range(1, n + 1):
            if i % 15 == 0:
                result.append("FizzBuzz")
            elif i % 3 == 0:
                result.append("Fizz")
            elif i % 5 == 0:
                result.append("Buzz")
            else:
                result.append(str(i))

        return result
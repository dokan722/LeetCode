import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem784(Problem):
    def test(self) -> bool:
        s = "a1b2"

        expected = ["a1b2", "a1B2", "A1b2", "A1B2"]

        result = self.letterCasePermutation(s)

        print1DArray(result)

        return result == expected

    def letterCasePermutation(self, s: str) -> List[str]:
        result = ['']
        for c in s:
            if c.isalpha():
                newResult = []
                for word in result:
                    newResult.append(word + str.lower(c))
                    newResult.append(word + str.upper(c))
                result = newResult
            else:
                result = [word + c for word in result]

        return result
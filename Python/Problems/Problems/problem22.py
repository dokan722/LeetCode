import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem22(Problem):
    def test(self) -> bool:
        n = 3

        expected = ["()()()", "()(())", "(())()", "(()())", "((()))"]

        result = self.generateParenthesis(n)

        print1DArray(result)

        return expected == result

    def generateParenthesis(self, n: int) -> list[str]:
        result = []
        l = 2 * n
        self.generateRec(result, "", 0, l)
        return result

    def generateRec(self, result: List[str],cur: str, d: int, l: int) -> None:
        if l - len(cur) < d:
            return
        if len(cur) == l:
            result.append(cur)
            return
        if d != 0:
            self.generateRec(result, cur + ")", d - 1, l)
        self.generateRec(result, cur + "(", d + 1, l)
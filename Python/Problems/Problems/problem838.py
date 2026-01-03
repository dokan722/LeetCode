import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem838(Problem):
    def test(self) -> bool:
        dominoes = ".L.R...LR..L.."

        expected = "LL.RR.LLRRLL.."

        result = self.pushDominoes(dominoes)

        print(result)

        return result == expected

    def pushDominoes(self, dominoes: str) -> str:
        n = len(dominoes)
        right = [0] * (n + 1)
        left = [0] * (n + 1)
        for i in range(1, n + 1):
            if dominoes[i - 1] == '.':
                right[i] = max(0, right[i - 1] - 1)
            elif dominoes[i - 1] == 'R':
                right[i] = n
            else:
                right[i] = 0
        for i in range(n - 1, -1, -1):
            if dominoes[i] == '.':
                left[i] = min(0, left[i + 1] + 1)
            elif dominoes[i] == 'L':
                left[i] = -n
            else:
                left[i] = 0

        result = []
        for i in range(n):
            val = right[i + 1] + left[i]
            if (val < 0):
                result.append('L')
            elif val > 0:
                result.append('R')
            else:
                result.append('.')

        return ''.join(result)
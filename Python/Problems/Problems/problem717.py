import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem717(Problem):
    def test(self) -> bool:
        bits = [1, 1, 1, 0]

        expected = False

        result = self.isOneBitCharacter(bits)

        return result == expected

    def isOneBitCharacter(self, bits: List[int]) -> bool:
        n = len(bits)
        i = 0
        while i < n:
            if bits[i] == 1:
                if i == n - 2:
                    return False
                i += 1
            else:
                if i == n - 1:
                    return True
            i += 1

        return True
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem781(Problem):
    def test(self) -> bool:
        answers = [1, 1, 2]

        expected = 5

        result = self.numRabbits(answers)

        print(result)

        return result == expected

    def numRabbits(self, answers: List[int]) -> int:
        result = 0
        added = [0] * 1002
        for a in answers:
            act = a + 1
            if act == 1 or added[act] % act == 0:
                result += act
            added[act] += 1

        return result
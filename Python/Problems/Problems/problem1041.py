import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1041(Problem):
    def test(self) -> bool:
        instructions = "GL"

        expected = True

        result = self.isRobotBounded(instructions)

        return result == expected

    def isRobotBounded(self, instructions: str) -> bool:
        dirs = [0] * 4
        curr = 0
        for instruction in instructions:
            if instruction == 'G':
                dirs[curr] += 1
            elif instruction == 'R':
                curr = (curr + 1) % 4
            else:
                curr = (curr + 3) % 4

        return curr != 0 or dirs[0] == dirs[2] and dirs[1] == dirs[3]
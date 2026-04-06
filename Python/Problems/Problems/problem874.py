import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem874(Problem):
    def test(self) -> bool:
        commands = [4, -1, 3]
        obstacles = []

        expected = 25

        result = self.robotSim(commands, obstacles)

        print(result)

        return result == expected

    def robotSim(self, commands: List[int], obstacles: List[List[int]]) -> int:
        obs = set()
        for o in obstacles:
            obs.add((o[0], o[1]))

        dirs = [[0, 1], [1, 0], [0, -1], [-1, 0]]
        curDir = 0
        x = 0
        y = 0
        result = 0
        for cmd in commands:
            if cmd == -1:
                curDir = (curDir + 1) % 4
            elif cmd == -2:
                curDir = (curDir - 1 + 4) % 4
            else:
                for i in range(cmd):
                    x += dirs[curDir][0]
                    y += dirs[curDir][1]
                    if (x, y) in obs:
                        x -= dirs[curDir][0]
                        y -= dirs[curDir][1]
                        break
                    result = max(result, x * x + y * y)

        return result
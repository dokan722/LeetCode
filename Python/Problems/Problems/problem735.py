import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem735(Problem):
    def test(self) -> bool:
        asteroids = [3, 5, -6, 2, -1, 4]

        expected = [-6, 2, 4]

        result = self.asteroidCollision(asteroids)

        print1DArray(result)

        return expected == result

    def asteroidCollision(self, asteroids: List[int]) -> List[int]:
        n = len(asteroids)
        train = []
        leftAst = []
        for i in range(n):
            if asteroids[i] > 0:
                train.append(asteroids[i])
            else:
                mass = abs(asteroids[i])
                while train and train[-1] < mass:
                    train.pop()
                if not train:
                    leftAst.append(asteroids[i])
                elif train[-1] == mass:
                    train.pop()

        return leftAst + train
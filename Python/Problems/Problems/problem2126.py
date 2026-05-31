import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2126(Problem):
    def test(self) -> bool:
        mass = 10
        asteroids = [3, 9, 19, 5, 21]

        expected = True

        result = self.asteroidsDestroyed(mass, asteroids)

        return result == expected

    def asteroidsDestroyed(self, mass: int, asteroids: List[int]) -> bool:
        curMass = mass
        asteroids.sort()
        for a in asteroids:
            if a > curMass:
                return False
            curMass += a

        return True
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2079(Problem):
    def test(self) -> bool:
        plants = [3, 2, 4, 2, 1]
        capacity = 6

        expected = 17

        result = self.wateringPlants(plants, capacity)

        print(result)

        return result == expected

    def wateringPlants(self, plants: List[int], capacity: int) -> int:
        n = len(plants)
        curr = capacity
        result = n
        for i in range(n):
            if curr < plants[i]:
                result += 2 * i
                curr = capacity - plants[i]
            else:
                curr -= plants[i]

        return result
import heapq
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3147(Problem):
    def test(self) -> bool:
        energy = [5, 2, -10, -5, 1]
        k = 3

        expected = 3

        result = self.maximumEnergy(energy, k)

        print(result)

        return expected == result

    def maximumEnergy(self, energy: List[int], k: int) -> int:
        n = len(energy)
        result = -sys.maxsize
        for i in range(n):
            if i + k < n:
                energy[i + k] = max(energy[i + k], energy[i + k] + energy[i])
            else:
                result = max(result, energy[i])

        return result
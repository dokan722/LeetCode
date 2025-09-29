from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem739(Problem):
    def test(self) -> bool:
        temperatures = [73, 74, 75, 71, 69, 72, 76, 73]

        expected = [1, 1, 4, 2, 1, 1, 0, 0]

        result = self.dailyTemperatures(temperatures)

        print1DArray(result)

        return expected == result

    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        n = len(temperatures)
        result = [0] * n
        temps = []

        for i in range(n - 1, -1, -1):
            count = 1
            while temps and temperatures[i] >= temps[-1][0]:
                count += temps[-1][1]
                temps.pop()
            result[i] =  0 if not temps else count
            temps.append((temperatures[i], result[i]))

        return result
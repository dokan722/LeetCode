from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem42(Problem):
    def test(self) -> bool:
        height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]

        expected = 6

        result = self.trap(height)

        print(result)

        return expected == result

    def trap(self, height: List[int]) -> int:
        n = len(height)
        maxId = 0
        result = 0
        waterCollected = 0
        for i in range(1, n):
            if height[i] >= height[maxId]:
                result += waterCollected
                waterCollected = 0
                maxId = i
            else:
                waterCollected += height[maxId] - height[i];

        border = maxId
        maxId = n - 1
        waterCollected = 0
        for i in range(n - 2, border - 1, - 1):
            if height[i] >= height[maxId]:
                result += waterCollected
                waterCollected = 0
                maxId = i
            else:
                waterCollected += height[maxId] - height[i]


        return result
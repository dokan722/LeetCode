import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2300(Problem):
    def test(self) -> bool:
        spells = [5, 1, 3]
        potions = [1, 2, 3, 4, 5]
        success = 7

        expected = [4, 0, 3]

        result = self.successfulPairs(spells, potions, success)

        print1DArray(result)

        return expected == result

    def successfulPairs(self, spells: List[int], potions: List[int], success: int) -> List[int]:
        n = len(spells)
        m = len(potions)
        potions.sort()
        result = []
        for i in range(n):
            req = (success + spells[i] - 1) // spells[i]
            if potions[0] >= req:
                result.append(m)
            elif potions[m - 1] < req:
                result.append(0)
            else:
                left = 0
                right = m - 1
                while left < right:
                    mid = (left + right + 1) // 2
                    if potions[mid] >= req:
                        right = mid - 1
                    else:
                        left = mid
                result.append(m - left - 1)

        return result
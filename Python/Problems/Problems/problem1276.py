import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1276(Problem):
    def test(self) -> bool:
        tomatoSlices = 4
        cheeseSlices = 17

        expected = []

        result = self.numOfBurgers(tomatoSlices, cheeseSlices)

        print1DArray(result)

        return expected == result

    def numOfBurgers(self, tomatoSlices: int, cheeseSlices: int) -> List[int]:
        doubleSlices = cheeseSlices * 2
        leftover = tomatoSlices - doubleSlices
        if doubleSlices > tomatoSlices or leftover % 2 == 1 or leftover > doubleSlices:
            return []
        jumbo = leftover // 2
        return [jumbo, cheeseSlices - jumbo]
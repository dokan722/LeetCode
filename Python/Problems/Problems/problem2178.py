import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2178(Problem):
    def test(self) -> bool:
        finalSum = 12

        expected = [2, 4, 6]

        result = self.maximumEvenSplit(finalSum)

        print1DArray(result)

        return expected == result

    def maximumEvenSplit(self, finalSum: int) -> List[int]:
        num = int((math.sqrt(4 * finalSum + 1) - 1) / 2)
        result = []
        for i in range(num):
            result.append(2 * i + 2)
        bonus = finalSum - 2 * (num * (num + 1) // 2)
        if bonus % 2 == 1:
            return []
        result[num - 1] += bonus
        return result
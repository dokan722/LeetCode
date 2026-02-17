import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem401(Problem):
    def test(self) -> bool:
        turnedOn = 9

        expected = []

        result = self.readBinaryWatch(turnedOn)

        print1DArray(result)

        return expected == result

    def readBinaryWatch(self, turnedOn: int) -> List[str]:
        result = []
        values = [8, 4, 2, 1, 32, 16, 8, 4, 2, 1]
        self.watchRec(0, turnedOn, 0, 0, 0, values, result)
        return result

    def watchRec(self, curr: int, limit: int, start: int, minutes: int, hours: int, values: List[int], result: List[str]) -> None:
        if minutes > 59 or hours > 11 or 10 - start < limit - curr:
            return
        if curr == limit:
            result.append(str(hours) + ":" + f"{minutes:02}")
            return
        for i in range(start, 4):
            self.watchRec(curr + 1, limit, i + 1, minutes, hours + values[i], values, result)
        for i in range(max(4, start), 10):
            self.watchRec(curr + 1, limit, i + 1, minutes + values[i], hours, values, result)
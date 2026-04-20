import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2437(Problem):
    def test(self) -> bool:
        time = "?5:00"

        expected = 2

        result = self.countTime(time)

        print(result)

        return result == expected

    def countTime(self, time: str) -> int:
        result = 1
        if time[0] == '?':
            if time[1] == '?':
                result *= 24
            else:
                if time[1] < '4':
                    result *= 3
                else:
                    result *= 2
        else:
            if time[1] == '?':
                if time[0] == '2':
                    result *= 4
                else:
                    result *= 10
        if time[3] == '?':
            result *= 6
        if time[4] == '?':
            result *= 10

        return result
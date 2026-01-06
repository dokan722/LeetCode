import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2651(Problem):
    def test(self) -> bool:
        arrivalTime = 15
        delayedTime = 5

        expected = 20

        result = self.findDelayedArrivalTime(arrivalTime, delayedTime)

        print(result)

        return result == expected

    def findDelayedArrivalTime(self, arrivalTime: int, delayedTime: int) -> int:
        return (arrivalTime + delayedTime) % 24
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1109(Problem):
    def test(self) -> bool:
        bookings = [[1, 2, 10], [2, 3, 20], [2, 5, 25]]
        n = 5

        expected = [10, 55, 45, 25, 25]

        result = self.corpFlightBookings(bookings, n)

        print1DArray(result)

        return expected == result

    def corpFlightBookings(self, bookings: List[List[int]], n: int) -> List[int]:
        sweepArray = [0] * (n + 1)
        for booking in bookings:
            first = booking[0] - 1
            last = booking[1] - 1
            seats = booking[2]
            sweepArray[first] += seats
            sweepArray[last + 1] -= seats

        result = []
        curBooked = 0
        for i in range(n):
            curBooked += sweepArray[i]
            result.append(curBooked)

        return result
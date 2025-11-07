import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2528(Problem):
    def test(self) -> bool:
        stations = [4, 2]
        r = 1
        k = 1

        expected = 7

        result = self.maxPower(stations, r, k)

        print(result)

        return result == expected

    def maxPower(self, stations: List[int], r: int, k: int) -> int:
        n = len(stations)
        l = sys.maxsize
        h = -sys.maxsize
        diff = [0] * n
        for i in range(n):
            station = stations[i]
            l = min(l, station)
            if i >= r:
                diff[i - r] += station
            else:
                diff[0] += station
            if i + r + 1 < n:
                diff[i + r + 1] -= station

        currStations = 0
        for i in range(n):
            currStations += diff[i]
            h = max(h, currStations)

            h += k
        while l < h:
            m = (l + h + 1) // 2
            ranges = [0] * n
            poss = True
            preSum = 0
            rem = k
            for i in range(n):
                preSum += diff[i]
                preSum += ranges[i]
                if preSum < m:
                    newStations = m - preSum
                    rem -= newStations
                    preSum += newStations
                    if i + 2 * r + 1 < n:
                        ranges[i + 2 * r + 1] -= newStations
                if rem < 0:
                    poss = False
                    break
            if poss:
                l = m
            else:
                h = m - 1

        return l
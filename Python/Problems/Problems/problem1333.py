import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1333(Problem):
    def test(self) -> bool:
        restaurants = [[1, 4, 1, 40, 10], [2, 8, 0, 50, 5], [3, 8, 1, 30, 4], [4, 10, 0, 10, 3], [5, 1, 1, 15, 1]]
        veganFriendly = 1
        maxPrice = 50
        maxDistance = 10

        expected = [3, 1, 5]

        result = self.filterRestaurants(restaurants, veganFriendly, maxPrice, maxDistance)

        print1DArray(result)

        return expected == result

    def filterRestaurants(self, restaurants: List[List[int]], veganFriendly: int, maxPrice: int, maxDistance: int) -> List[int]:
        result = []
        ratings = dict()
        for r in restaurants:
            if veganFriendly == 1 and r[2] == 0:
                continue
            if r[3] <= maxPrice and r[4] <= maxDistance:
                result.append(r[0])
                ratings[r[0]] = r[1]
        result.sort(key=lambda x: (-ratings[x], -x))
        return result
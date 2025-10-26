import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem841(Problem):
    def test(self) -> bool:
        rooms = [[1], [2], [3], []]

        expected = True

        result = self.canVisitAllRooms(rooms)

        return expected == result

    def canVisitAllRooms(self, rooms: List[List[int]]) -> bool:
        n = len(rooms)
        covered = 0
        visited = [False] * n
        toVisit = []
        toVisit.append(0)
        while toVisit:
            next = toVisit.pop()
            if visited[next]:
                continue
            covered += 1
            visited[next] = True
            for key in rooms[next]:
                if not visited[key]:
                    toVisit.append(key)

        return covered == n
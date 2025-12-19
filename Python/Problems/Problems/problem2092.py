import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2092(Problem):
    def test(self) -> bool:
        n = 4
        meetings = [[3, 1, 3], [1, 2, 2], [0, 3, 3]]
        firstPerson = 3

        expected = [0, 1, 3]

        result = self.findAllPeople(n, meetings, firstPerson)

        print1DArray(result)

        return expected == result

    def findAllPeople(self, n: int, meetings: List[List[int]], firstPerson: int) -> List[int]:
        ubf = [ i for i in range(n)]
        self.union(0, firstPerson, ubf)
        meetings.sort(key=lambda x: x[2])
        present = set()
        prev = meetings[0][2]
        for meeting in meetings:
            if prev != meeting[2]:
                for p in present:
                    if self.find(p, ubf) == 0:
                        ubf[p] = 0
                    else:
                        ubf[p] = p
                prev = meeting[2]
                present = set()
            present.add(meeting[0])
            present.add(meeting[1])
            self.union(meeting[0], meeting[1], ubf)
        result = []
        for i in range(n):
            if self.find(i, ubf) == 0:
                result.append(i)
        return result

    def find(self, x: int, ubf: List[int]) -> int:
        if x == ubf[x]:
            return x
        return self.find(ubf[x], ubf)

    def union(self, x: int, y: int, ubf: List[int]) -> None:
        px = self.find(x, ubf)
        py = self.find(y, ubf)
        if py == 0:
            ubf[px] = 0
        else:
            ubf[py] = px
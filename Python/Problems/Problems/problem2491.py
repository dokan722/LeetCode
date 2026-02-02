import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2491(Problem):
    def test(self) -> bool:
        skill = [3, 2, 5, 1, 3, 4]

        expected = 22

        result = self.dividePlayers(skill)

        print(result)

        return result == expected

    def dividePlayers(self, skill: List[int]) -> int:
        n = len(skill)
        sum = 0
        skills = dict()
        for s in skill:
            if s in skills:
                skills[s] += 1
            else:
                skills[s] = 1
            sum += s
        if sum % (n // 2) != 0:
            return -1
        target = sum // (n // 2)
        result = 0
        for s in skill:
            req = target - s
            if req not in skills or skills[req] != skills[s]:
                return -1
            result += s * req

        return result // 2
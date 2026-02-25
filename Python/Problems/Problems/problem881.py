import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem881(Problem):
    def test(self) -> bool:
        people = [3, 2, 2, 1]
        limit = 3

        expected = 3

        result = self.numRescueBoats(people, limit)

        print(result)

        return result == expected

    def numRescueBoats(self, people: List[int], limit: int) -> int:
        people.sort()
        l = 0
        r = len(people) - 1
        result = 0
        while (l < r):
            if people[l] + people[r] <= limit:
                l += 1
                r -= 1
            else:
                r -= 1
            result +=1
        if l == r:
            result += 1
        return result
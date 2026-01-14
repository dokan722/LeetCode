import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2225(Problem):
    def test(self) -> bool:
        matches = [[2, 3], [1, 3], [5, 4], [6, 4]]

        expected = [[1, 2, 5, 6], []]

        result = self.findWinners(matches)

        print2DArray(result)

        return expected == result

    def findWinners(self, matches: List[List[int]]) -> List[List[int]]:
        results = dict()
        for match in matches:
            if match[0] not in results:
                results[match[0]] = 0
            if match[1] not in results:
                results[match[1]] = 0
            results[match[1]] += 1
        no = []
        one = []

        for result in results.items():
            if result[1] == 0:
                no.append(result[0])
            elif result[1] == 1:
                one.append(result[0])
        no.sort()
        one.sort()
        return [no, one]
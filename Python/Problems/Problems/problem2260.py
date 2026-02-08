import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2260(Problem):
    def test(self) -> bool:
        cards = [3, 4, 2, 3, 4, 7]

        expected = 4

        result = self.minimumCardPickup(cards)

        print(result)

        return result == expected

    def minimumCardPickup(self, cards: List[int]) -> int:
        n = len(cards)
        pos = dict()
        result = sys.maxsize
        for i in range(n):
            if cards[i] in pos:
                result = min(result, i - pos[cards[i]] + 1)
            pos[cards[i]] = i

        return -1 if result == sys.maxsize else result
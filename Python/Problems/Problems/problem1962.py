import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1962(Problem):
    def test(self) -> bool:
        piles = [4, 3, 6, 7]
        k = 3

        expected = 12

        result = self.minStoneSum(piles, k)

        print(result)

        return expected == result

    def minStoneSum(self, piles: List[int], k: int) -> int:
        n = len(piles)
        que = []
        sum = 0
        for pile in piles:
            heapq.heappush(que, -pile)
            sum += pile

        for i in range(k):
            next = -heapq.heappop(que)
            toRemove = next // 2
            if toRemove == 0:
                break
            sum -= toRemove
            newPile = next - toRemove
            heapq.heappush(que, -newPile)

        return sum
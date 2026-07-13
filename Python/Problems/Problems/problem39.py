import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem39(Problem):
    def test(self) -> bool:
        candidates = [2, 3, 6, 7]
        target = 7

        expected = [[2, 2, 3], [7]]

        result = self.combinationSum(candidates, target)

        print2DArray(result)

        return expected == result

    def searchRec(self, result: List[List[int]], cur: List[int], cands: List[int], rem: int, start: int) -> None:
        if rem < 0:
            return
        if rem == 0:
            result.append(list(cur))
            return
        for i in range(start, len(cands)):
            cur.append(cands[i])
            self.searchRec(result, cur, cands, rem - cands[i], i)
            cur.pop()

    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
        result = []
        cur = []
        self.searchRec(result, cur, candidates, target, 0)
        return result
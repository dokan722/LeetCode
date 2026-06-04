import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3635(Problem):
    def test(self) -> bool:
        landStartTime = [2, 8]
        landDuration = [4, 1]
        waterStartTime = [6]
        waterDuration = [3]

        expected = 9

        result = self.earliestFinishTime(landStartTime, landDuration, waterStartTime, waterDuration)

        print(result)

        return result == expected

    def earliestFinishTime(self, landStartTime: List[int], landDuration: List[int], waterStartTime: List[int], waterDuration: List[int]) -> int:
        nl = len(landStartTime)
        nw = len(waterStartTime)
        li = 0
        wi = 0
        for i in range(1, nl):
            if landStartTime[i] + landDuration[i] < landStartTime[li] + landDuration[li]:
                li = i
        for i in range(1, nw):
            if waterStartTime[i] + waterDuration[i] < waterStartTime[wi] + waterDuration[wi]:
                wi = i
        lf = sys.maxsize
        for i in range(nw):
            end = max(landStartTime[li] + landDuration[li], waterStartTime[i]) + waterDuration[i]
            lf = min(lf, end)
        wf = sys.maxsize
        for i in range(nl):
            end = max(waterStartTime[wi] + waterDuration[wi], landStartTime[i]) + landDuration[i]
            wf = min(wf, end)

        return min(lf, wf)
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1904(Problem):
    def test(self) -> bool:
        loginTime = "09:31"
        logoutTime = "10:14"

        expected = 1

        result = self.numberOfRounds(loginTime, logoutTime)

        print(result)

        return result == expected

    def numberOfRounds(self, loginTime: str, logoutTime: str) -> int:
        inTs = int(loginTime[:2]) * 60 + int(loginTime[3:])
        outTs = int(logoutTime[:2]) * 60 + int(logoutTime[3:])
        first = (inTs + 14) // 15
        last = outTs // 15
        if inTs < outTs and first > last:
            return 0

        return last - first if first <= last else (4 * 24) - first + last
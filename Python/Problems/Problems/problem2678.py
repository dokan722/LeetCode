import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2678(Problem):
    def test(self) -> bool:
        details = ["7868190130M7522", "5303914400F9211", "9273338290F4010"]

        expected = 2

        result = self.countSeniors(details)

        print(result)

        return result == expected

    def countSeniors(self, details: List[str]) -> int:
        result = 0
        for d in details:
            if ord(d[11]) > ord('6') or (ord(d[11]) == ord('6') and ord(d[12]) > ord('0')):
                result += 1

        return result
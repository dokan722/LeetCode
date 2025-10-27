import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2125(Problem):
    def test(self) -> bool:
        bank = ["011001", "000000", "010100", "001000"]

        expected = 8

        result = self.numberOfBeams(bank)

        print(result)

        return result == expected

    def numberOfBeams(self, bank: List[str]) -> int:
        last = 0
        result = 0
        for row in bank:
            count = row.count("1")
            if count > 0:
                result += last * count
                last = count

        return result
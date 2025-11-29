import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3561(Problem):
    def test(self) -> bool:
        s = "zadb"

        expected = "db"

        result = self.resultingString(s)

        print(result)

        return result == expected

    def resultingString(self, s: str) -> str:
        chars = []
        for c in s:
            if chars:
                diff = (ord(chars[-1]) - ord(c) + 26) % 26
                if diff == 1 or diff == 25:
                    chars.pop()
                else:
                    chars.append(c)
            else:
                chars.append(c)

        return ''.join(chars)
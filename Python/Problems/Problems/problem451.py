import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem451(Problem):
    def test(self) -> bool:
        s = "Aabb"

        expected = "bbAa"

        result = self.frequencySort(s)

        print(result)

        return expected == result

    def frequencySort(self, s: str) -> str:
        counts = dict()
        for c in s:
            if c in counts:
                counts[c] += 1
            else:
                counts[c] = 1
        pairs = []
        for count in counts.items():
            pairs.append((count[1], count[0]))
        pairs.sort(key=lambda pair: (-pair[0], pair[1]))
        result = ''
        for pair in pairs:
            result += pair[1] * pair[0]

        return result
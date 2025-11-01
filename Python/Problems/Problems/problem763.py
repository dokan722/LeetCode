import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem763(Problem):
    def test(self) -> bool:
        s = "ababcbacadefegdehijhklij"

        expected = [9, 7, 8]

        result = self.partitionLabels(s)

        print1DArray(result)

        return result == expected

    def partitionLabels(self, s: str) -> List[int]:
        n = len(s)
        last = [0] * 26
        for i in range(n):
            last[ord(s[i]) - ord('a')] = i

        start = -1
        end = 0
        result = []
        for i in range(n):
            end = max(end, last[ord(s[i]) - ord('a')])
            if end == i:
                result.append(end - start)
                start = i

        return result
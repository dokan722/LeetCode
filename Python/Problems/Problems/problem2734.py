import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2734(Problem):
    def test(self) -> bool:
        s = "cbabc"

        exected = "baabc"

        result = self.smallestString(s)

        print(result)

        return result == exected

    def smallestString(self, s: str) -> str:
        n = len(s)
        start = -1
        end = n
        map = []
        map.append('z')
        for  i in range(1, 26):
            map.append(chr(ord('a') + i - 1))
        for i in range(n):
            if start == -1 and s[i] != 'a':
                start = i
            elif start != -1 and s[i] == 'a':
                end = i
                break
        if start == -1:
            return 'a' * (n - 1) + "z"

        changed = []
        for i in range(start, end):
            changed.append(map[ord(s[i]) - ord('a')])
        return s[:start] + ''.join(changed) + s[end:]
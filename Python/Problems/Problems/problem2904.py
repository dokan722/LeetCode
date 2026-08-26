import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2904(Problem):
    def test(self) -> bool:
        s = "100011001"
        k = 3

        expected = "11001"

        result = self.shortestBeautifulSubstring(s, k)

        print(result)

        return result == expected

    def shortestBeautifulSubstring(self, s: str, k: int) -> str:
        n = len(s)
        result = ""
        i = 0
        while i < n and s[i] != '1':
            i += 1
        if i == n:
            return result
        if k == 1:
            return "1"
        cur = 1
        last = i
        for i in range(i + 1, n):
            if s[i] == '1':
                if cur < k:
                    cur += 1
                else:
                    last += 1
                    while s[last] != '1':
                        last += 1
                if cur == k:
                    res = s[last:(i + 1)]
                    if result == "" or len(result) > len(res) or (len(result) == len(res) and res < result):
                        result = res

        return result
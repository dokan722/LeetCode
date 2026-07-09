import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1967(Problem):
    def test(self) -> bool:
        patterns = ["a", "abc", "bc", "d"]
        word = "abc"

        expected = 3

        result = self.numOfStrings(patterns, word)

        print(result)

        return result == expected

    def numOfStrings(self, patterns: List[str], word: str) -> int:
        n = len(word)
        present = set()
        notPresent = set()
        result = 0
        for p in patterns:
            if p in present:
                result += 1
            elif p not in notPresent:
                m = len(p)
                prefs = [0]
                l = 0
                d = 1
                while d < m:
                    if p[d] == p[l]:
                        l += 1
                        prefs.append(l)
                        d += 1
                    else:
                        if l != 0:
                            l = prefs[l - 1]
                        else:
                            prefs.append(0)
                            d += 1
                l = 0
                d = 0
                while d < n:
                    if l == m:
                        break
                    if word[d] == p[l]:
                        l += 1
                        d += 1
                    elif l != 0:
                        l = prefs[l - 1]
                    else:
                        d += 1
                if l == m:
                    present.add(p)
                    result += 1
                else:
                    notPresent.add(p)
        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2452(Problem):
    def test(self) -> bool:
        queries = ["word", "note", "ants", "wood"]
        dictionary = ["wood", "joke", "moat"]

        expected = ["word", "note", "wood"]

        result = self.twoEditWords(queries, dictionary)

        print1DArray(result)

        return expected == result

    def twoEditWords(self, queries: List[str], dictionary: List[str]) -> List[str]:
        n = dict()
        result = []
        for query in queries:
            found = False
            for word in dictionary:
                if (len(query) != len(word)):
                    continue
                l = len(query)
                diff = 0
                i = 0
                while i < l and diff <= 2:
                    if word[i] != query[i]:
                        diff += 1
                    i += 1
                if diff <= 2:
                    found = True
                    break
            if found:
                result.append(query)
        return result
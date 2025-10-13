import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2273(Problem):
    def test(self) -> bool:
        words = ["abba", "baba", "bbaa", "cd", "cd"]

        expected = ["abba", "cd"]

        result = self.removeAnagrams(words)

        print1DArray(result)

        return result == expected

    def removeAnagrams(self, words: List[str]) -> List[str]:
        result = [words[0]]
        current = list(words[0])
        current.sort()
        for word in words:
            sorted = list(word)
            sorted.sort()
            if sorted == current:
                continue
            result.append(word)
            current = sorted

        return result
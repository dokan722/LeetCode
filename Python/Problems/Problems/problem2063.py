import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2063(Problem):
    def test(self) -> bool:
        word = "aba"

        expected = 6

        result = self.countVowels(word)

        print(result)

        return result == expected

    def countVowels(self, word: str) -> int:
        n = len(word)
        result = 0
        for i in range(n):
            c = word[i]
            if c == 'a' or c == 'e' or c == 'i' or c == 'o' or c == 'u':
                before = i + 1
                after = n - i
                result += before * after

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem520(Problem):
    def test(self) -> bool:
        word = "USA"

        expected = True

        result = self.detectCapitalUse(word)

        print(result)

        return result == expected

    def detectCapitalUse(self, word: str) -> bool:
        n = len(word)
        if n == 1:
            return True
        big = ord(word[1]) < ord('a')
        if big and ord(word[0]) >= ord('a'):
            return False
        for i in range(2, n):
            if big != (ord(word[i]) < ord('a')):
                return False

        return True
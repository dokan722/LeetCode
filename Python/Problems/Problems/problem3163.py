import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3163(Problem):
    def test(self) -> bool:
        word = "aaaaaaaaaaaaaabb"

        expected = "9a5a2b"

        result = self.compressedString(word)

        print(result)

        return result == expected

    def compressedString(self, word: str) -> str:
        n = len(word)
        start = 0
        curr = word[0]
        result = ''
        for i in range(1, n):
            if curr != word[i]:
                l = i - start
                full = l // 9
                rest = l % 9
                result += f'9{curr}' * full
                if rest != 0:
                    result += f'{rest}{curr}'
                curr = word[i]
                start = i
        fl = n - start
        ffull = fl // 9
        frest = fl % 9
        result += f'9{curr}' * ffull
        if frest != 0:
            result += f'{frest}{curr}'

        return result
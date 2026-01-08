import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1781(Problem):
    def test(self) -> bool:
        s = "aabcbaa"

        expected = 17

        result = self.beautySum(s)

        print(result)

        return result == expected

    def beautySum(self, s: str) -> int:
        n = len(s)
        result = 0
        for i in range(n):
            freq = [0] * 26
            for j in range(i, n):
                top = 0
                bot = 2137
                id = ord(s[j]) - ord('a')
                freq[id] += 1
                for k in range(26):
                    if freq[k] == 0:
                        continue
                    top = max(top, freq[k])
                    bot = min(bot, freq[k])

                if bot != 2137:
                    result += top - bot

        return result